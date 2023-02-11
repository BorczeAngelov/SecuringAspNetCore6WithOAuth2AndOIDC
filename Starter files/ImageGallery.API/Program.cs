using ImageGallery.API.Authorization;
using ImageGallery.API.DbContexts;
using ImageGallery.API.Services;
using ImageGallery.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(configure => configure.JsonSerializerOptions.PropertyNamingPolicy = null);

builder.Services.AddDbContext<GalleryContext>(options =>
{
    options.UseSqlite(
        builder.Configuration["ConnectionStrings:ImageGalleryDBConnectionString"]);
});


builder.Services.AddScoped<IGalleryRepository, GalleryRepository>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<IAuthorizationHandler, MustOwnImageHandler>(); //use classes from authorization layer


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


// Access tokens are passed to the API as Bearer tokens
// JwtBearerToken middleware is used to validate an access token at level of the API
// ***
// At level of API we use the User object to get Claims that are in the access token.
// If we need additional Claims we can configure that at the level of the identity server.
JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
          //.AddJwtBearer(options => // we replace Jwt with RefrenceToken
          //{
          //    options.Authority = "https://localhost:5001";
          //    options.Audience = "imagegalleryapi";
          //    options.TokenValidationParameters = new()
          //    {
          //        NameClaimType = "given_name",
          //        RoleClaimType = "role",
          //        ValidTypes = new[] { "at+jwt" }
          //    };
          //});
          .AddOAuth2Introspection(options => // we replace Jwt with RefrenceToken
          {
              options.Authority = "https://localhost:5001";
              options.ClientId = "imagegalleryapi";
              options.ClientSecret = "apisecret";
              options.NameClaimType = "given_name";
              options.RoleClaimType = "role";
          });

builder.Services.AddAuthorization(authorizationOptions =>
{
    authorizationOptions.AddPolicy(
        name: "UserCanAddImage",
        policy: AuthorizationPolicies.CanAddImage());

    authorizationOptions.AddPolicy(
        name: "ClientApplicationCanWrite",
        configurePolicy: policyBulder =>
        {
            policyBulder.RequireClaim("scope", "imagegalleryapi.write");
        });

    authorizationOptions.AddPolicy(
        name: "MustOwnImage",
        configurePolicy: policyBulder =>
        {
            policyBulder.RequireAuthenticatedUser();
            policyBulder.AddRequirements(new MustOwnImageRequirement()); //use classes from authorization layer
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
