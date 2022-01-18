using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class ChangePropertiesModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39717e88-b638-4eea-8d03-66ae082576d4",
                column: "ConcurrencyStamp",
                value: "c1737646-8020-4d21-aed8-23fd41451c32");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ac2ee9b-a1e1-4c88-89f9-3a0e84277858",
                column: "ConcurrencyStamp",
                value: "039ca24c-dd40-4a15-b0eb-4429a0361b92");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26a33fbd-cd1b-4b69-a1c9-e0e49369614d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fed33f21-5861-42d1-98f3-1d22115b874d", "AQAAAAEAACcQAAAAEGKcc038sA9VeoBjV0B1vuKl56kpuUJcJOqU9m0fGYTelQnbS5AtrFy6nd7wYEcAyw==", "c91586eb-41e2-438f-8227-fcccfb2f8021" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "344c7353-8798-4d33-93d4-55ca31fac122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f2b4f3a-d7d2-4266-ab37-0c5ce24bc7b5", "AQAAAAEAACcQAAAAEAYmW0V97BbNpZWMXwAWdJrhXuFlHbqDmxctKshrzB7615nX7HnRjbaJU5Wswp4/4w==", "32a21775-737c-4084-b2e9-60a0d416b63d" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(9006), new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(9013), new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(8704), new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(8765), new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(9088), new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(9093), new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(9097), new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 1, 14, 10, 10, 2, 61, DateTimeKind.Local).AddTicks(9102) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26a33fbd-cd1b-4b69-a1c9-e0e49369614d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b651e56-bf9a-41e3-9ee3-07c2fc42fc39", "AQAAAAEAACcQAAAAEHeljuyq0GhlG7jOLuKMuMZwJHG2sByVuvTQ1LCwZQsqvygzVzQd73T2zQD9ft5t6g==", "b56badc7-7d59-400f-989e-c9c371d9efa5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "344c7353-8798-4d33-93d4-55ca31fac122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "933080da-0a3b-4a9a-a0c1-64580c3433a2", "AQAAAAEAACcQAAAAECaf/fxvayj9PF60ME+Y2Ol5MNZsMnm+XEgHfz+Htw9+tt5AiTcSFs3kBPoVPlj0nQ==", "e8613763-6e10-46be-9f3e-cafefd20b26b" });

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
        }
    }
}
