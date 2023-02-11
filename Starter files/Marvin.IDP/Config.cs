using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace Marvin.IDP;

public static class Config
{
    // Access tokens are passed to the API as Bearer tokens
    // JwtBearerToken middleware is used to validate an access token at level of the API
    // ***
    // At level of API we use the User object to get Claims that are in the access token.
    // If we need additional Claims we can configure that at the level of the identity server.
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(), // map standardized scope 
            new IdentityResources.Profile(), // map standardized scope 

            new IdentityResource(
                name: "roles",
                displayName: "Your role(s)",
                userClaims: new[] { "role" }),

            new IdentityResource(
                name: "country",
                displayName: "The country you're living in",
                userClaims: new List<string> { "country" }),
        };

    public static IEnumerable<ApiResource> ApiResources =>
        new ApiResource[]
        {
            new ApiResource(
                name: "imagegalleryapi",
                displayName: "Image Gallery API",
                new [] { "role", "country" })
            {
                Scopes =
                {
                    "imagegalleryapi.fullaccess",
                    "imagegalleryapi.read",
                    "imagegalleryapi.write",
                },
                ApiSecrets = { new Secret("apisecret".Sha256()) }
            }
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
            {
                new ApiScope(name: "imagegalleryapi.fullaccess"),
                new ApiScope(name: "imagegalleryapi.read"),
                new ApiScope(name: "imagegalleryapi.write"),
            };

    public static IEnumerable<Client> Clients =>
        new Client[]
            {
                new Client()
                {
                    ClientName = "Image Gallery",
                    ClientId= "imagegalleryclient",
                    AllowedGrantTypes = GrantTypes.Code,

                    AccessTokenType = AccessTokenType.Reference, // we replace Jwt with RefrenceToken

                    AllowOfflineAccess = true,
                    UpdateAccessTokenClaimsOnRefresh = true,
                    AccessTokenLifetime = 120, //default 1 hour
                    //AuthorizationCodeLifetime = 300; //default 300s
                    //IdentityTokenLifetime = 300; //default 300s

                    RedirectUris =
                    {
                         "https://localhost:7184/signin-oidc"
                    },
                    PostLogoutRedirectUris =
                    {
                        "https://localhost:7184/signout-callback-oidc"
                    },
                    AllowedScopes =
                    {
                         IdentityServerConstants.StandardScopes.OpenId,
                         IdentityServerConstants.StandardScopes.Profile,
                         "roles",
                         //"imagegalleryapi.fullaccess",
                         "imagegalleryapi.read",
                         "imagegalleryapi.write",
                         "country"
                    },
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    RequireConsent = true,
               }
            };
}