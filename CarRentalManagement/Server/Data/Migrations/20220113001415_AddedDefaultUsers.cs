using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39717e88-b638-4eea-8d03-66ae082576d4",
                column: "ConcurrencyStamp",
                value: "cb926f4e-c06e-4564-adeb-725714e84db4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ac2ee9b-a1e1-4c88-89f9-3a0e84277858",
                column: "ConcurrencyStamp",
                value: "a4cafdf1-1024-42d1-bba3-e5aa5b246da2");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "26a33fbd-cd1b-4b69-a1c9-e0e49369614d", 0, "7b651e56-bf9a-41e3-9ee3-07c2fc42fc39", "admin@localhost.com", false, "System", "Admin ", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHeljuyq0GhlG7jOLuKMuMZwJHG2sByVuvTQ1LCwZQsqvygzVzQd73T2zQD9ft5t6g==", null, false, "b56badc7-7d59-400f-989e-c9c371d9efa5", false, "admin@localhost.com" },
                    { "344c7353-8798-4d33-93d4-55ca31fac122", 0, "933080da-0a3b-4a9a-a0c1-64580c3433a2", "user@localhost.com", false, "System", "User ", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAECaf/fxvayj9PF60ME+Y2Ol5MNZsMnm+XEgHfz+Htw9+tt5AiTcSFs3kBPoVPlj0nQ==", null, false, "e8613763-6e10-46be-9f3e-cafefd20b26b", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(3172), new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(3181), new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(2844), new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(2896), new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(3290), new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(3296), new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(3302), new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(3307), new DateTime(2022, 1, 12, 17, 14, 14, 796, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "39717e88-b638-4eea-8d03-66ae082576d4", "26a33fbd-cd1b-4b69-a1c9-e0e49369614d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5ac2ee9b-a1e1-4c88-89f9-3a0e84277858", "344c7353-8798-4d33-93d4-55ca31fac122" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39717e88-b638-4eea-8d03-66ae082576d4", "26a33fbd-cd1b-4b69-a1c9-e0e49369614d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ac2ee9b-a1e1-4c88-89f9-3a0e84277858", "344c7353-8798-4d33-93d4-55ca31fac122" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26a33fbd-cd1b-4b69-a1c9-e0e49369614d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "344c7353-8798-4d33-93d4-55ca31fac122");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39717e88-b638-4eea-8d03-66ae082576d4",
                column: "ConcurrencyStamp",
                value: "fd7ff3af-7c52-4fa8-a08b-ded4b3a08650");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ac2ee9b-a1e1-4c88-89f9-3a0e84277858",
                column: "ConcurrencyStamp",
                value: "457356fd-7bdf-47b6-b1c9-132c9d97b8b4");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3747), new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3756), new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3431), new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3481), new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3860), new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3867), new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3873), new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3878), new DateTime(2022, 1, 12, 17, 2, 14, 245, DateTimeKind.Local).AddTicks(3880) });
        }
    }
}
