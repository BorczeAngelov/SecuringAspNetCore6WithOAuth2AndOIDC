using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marvin.IDP.Migrations
{
    public partial class AddSecurityCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("1983d177-267f-4e49-b151-3ff8a89545e4"), "170dcfb9-4aba-4e75-9ff2-8b959e450c3f", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("314d9dda-4a45-4c9a-9203-5b1de3509bb3"), "ad03581a-ce0d-41fc-85f3-fbed98e73457", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("4dc0f8a5-c013-4ec1-a0f0-e1a8ae3cee52"), "a1c42ba9-e898-428a-ba02-ef368582db74", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("60e1bc6a-ac0e-4421-bac9-bd547489beed"), "7ee56f32-3415-48ef-a2e0-1ec13e31438a", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("7142a082-c8d3-4d5a-af2a-28418ea5ff70"), "06dbbb37-d842-4526-bc10-334622032c9b", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("8e4c29bb-977f-49e6-abeb-c1d2a37e1e16"), "04a1a656-c28d-4cbd-b946-e9b45f5661d9", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("ce62b44a-cfc5-4bd3-b5e9-05e35d9b9a42"), "5ed4a755-9c94-4a11-873f-016096c68e0f", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[] { new Guid("ea381d05-8b09-4bee-b676-9cf7a46e5493"), "1c2a67da-462f-4eb3-970c-0c7916ff819b", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "5ea8c2c0-7e01-4b91-b023-e5b6bbcd6e49");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "d1748347-18e4-40b9-91ce-b7cb457e363a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("1983d177-267f-4e49-b151-3ff8a89545e4"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("314d9dda-4a45-4c9a-9203-5b1de3509bb3"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4dc0f8a5-c013-4ec1-a0f0-e1a8ae3cee52"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("60e1bc6a-ac0e-4421-bac9-bd547489beed"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7142a082-c8d3-4d5a-af2a-28418ea5ff70"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8e4c29bb-977f-49e6-abeb-c1d2a37e1e16"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ce62b44a-cfc5-4bd3-b5e9-05e35d9b9a42"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ea381d05-8b09-4bee-b676-9cf7a46e5493"));

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

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
                column: "ConcurrencyStamp",
                value: "6a65a13d-3000-40a4-aad6-abc1664dbf57");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "c506d62d-14e1-4845-ac4e-088f6516b036");
        }
    }
}
