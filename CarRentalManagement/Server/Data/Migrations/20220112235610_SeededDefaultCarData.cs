using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "SystemAdmin", new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6065), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6073), "Toyota", "SystemAdmin" },
                    { 2, "SystemAdmin", new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6077), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6079), "BMW", "SystemAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "SystemAdmin", new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(5743), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(5788), "Red", "SystemAdmin" },
                    { 2, "SystemAdmin", new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(5795), "Black", "SystemAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "SystemAdmin", new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6218), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6224), "Prius", "SystemAdmin" },
                    { 2, "SystemAdmin", new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6233), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6235), "Supra", "SystemAdmin" },
                    { 3, "SystemAdmin", new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6237), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6240), "3 Series", "SystemAdmin" },
                    { 4, "SystemAdmin", new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6243), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6245), "X5", "SystemAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
