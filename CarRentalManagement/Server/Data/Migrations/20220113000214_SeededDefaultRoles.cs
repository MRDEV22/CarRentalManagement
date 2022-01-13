using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "39717e88-b638-4eea-8d03-66ae082576d4", "fd7ff3af-7c52-4fa8-a08b-ded4b3a08650", "Administrator", "ADMINISTRATOR" },
                    { "5ac2ee9b-a1e1-4c88-89f9-3a0e84277858", "457356fd-7bdf-47b6-b1c9-132c9d97b8b4", "User", "USER" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39717e88-b638-4eea-8d03-66ae082576d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ac2ee9b-a1e1-4c88-89f9-3a0e84277858");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6065), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6077), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(5743), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6218), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6233), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6237), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6243), new DateTime(2022, 1, 12, 16, 56, 10, 426, DateTimeKind.Local).AddTicks(6245) });
        }
    }
}
