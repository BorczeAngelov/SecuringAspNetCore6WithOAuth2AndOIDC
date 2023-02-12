using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marvin.IDP.Migrations
{
    public partial class AddAccountActivation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0a209b3a-7b53-42db-8763-8caaf9672e6b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0ad70af1-4088-4b81-a3a2-10811bb8273c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("25fd0f9e-68b5-4668-81c3-c97e74dafecc"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("2c0c1ede-a24f-4e56-8f60-b710234822e8"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("98f951fb-d404-49e7-a2d0-10180da701f1"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d10a19e1-864a-4959-992f-b4bb95a3558d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("da9c9f6b-6cfb-493a-b6e4-3ecf5b003517"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("fbb22ffc-d2d1-4ee7-a7f3-f0dbe64bb75a"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("1eff0197-ba5b-437f-8f0d-386a422f016a"), "1391c349-248d-4d90-883f-90eaa5133007", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("31bc05ea-c924-4401-989c-43a2c36fed59"), "b41f32d5-c928-4e6b-823e-63b559875956", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("4dbd3272-ff83-4324-94a2-f5566bb51bcf"), "ca6db956-d1d5-4143-b53a-31376f9e0782", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("5105c20b-30d7-4606-85e9-1990e73aa19b"), "45099ee1-00e4-4a18-93b4-f086e6b518b7", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("522beeae-dde8-46ba-ae1f-723f44d0aece"), "0357a8f3-ac7a-4335-ad27-6c87e70e9dd0", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("65b8c3c8-2947-4c32-931c-ccb0f791da5f"), "16a4d48a-22e4-4fdb-b97b-b8a676ad4573", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("a0d46f85-e634-488e-965e-be417832c815"), "3874ab60-cab2-466a-bae1-073d7b8d75dd", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("adee9b06-b0b6-4390-962f-1035b6ee4f6b"), "d775c083-de94-43d8-af8a-8fb8a6e47165", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Email" },
                values: new object[] { "6a65a13d-3000-40a4-aad6-abc1664dbf57", "david@someprovider.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Email" },
                values: new object[] { "c506d62d-14e1-4845-ac4e-088f6516b036", "emma@someprovider.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("1eff0197-ba5b-437f-8f0d-386a422f016a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("31bc05ea-c924-4401-989c-43a2c36fed59"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4dbd3272-ff83-4324-94a2-f5566bb51bcf"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("5105c20b-30d7-4606-85e9-1990e73aa19b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("522beeae-dde8-46ba-ae1f-723f44d0aece"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("65b8c3c8-2947-4c32-931c-ccb0f791da5f"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a0d46f85-e634-488e-965e-be417832c815"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("adee9b06-b0b6-4390-962f-1035b6ee4f6b"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("0a209b3a-7b53-42db-8763-8caaf9672e6b"), "c15e16e2-4662-4948-96d3-fd84a67fbad0", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("0ad70af1-4088-4b81-a3a2-10811bb8273c"), "79fa7b6f-33a5-4fb0-beb4-b69f07d2f3b6", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("25fd0f9e-68b5-4668-81c3-c97e74dafecc"), "819f1c06-8912-4bc6-b6c5-50b7ebc2bbba", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("2c0c1ede-a24f-4e56-8f60-b710234822e8"), "4ae51a29-1496-4a50-8d69-1c15831eccd5", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("98f951fb-d404-49e7-a2d0-10180da701f1"), "e883c9ff-d8bd-4ed3-8308-952fb38c7b12", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("d10a19e1-864a-4959-992f-b4bb95a3558d"), "39379964-5bac-488a-ba42-be0f33e0798b", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("da9c9f6b-6cfb-493a-b6e4-3ecf5b003517"), "aa86e02b-06eb-404a-a1d3-52013da41416", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("fbb22ffc-d2d1-4ee7-a7f3-f0dbe64bb75a"), "8f5de25c-c093-42b1-af8a-da11135e977e", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "81181579-0ea4-4b81-a849-5d38660a2855");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "b98047c3-574b-4ff3-9ea3-657fab6873b7");
        }
    }
}
