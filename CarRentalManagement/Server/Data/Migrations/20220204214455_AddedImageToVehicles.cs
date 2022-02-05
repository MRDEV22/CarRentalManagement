using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedImageToVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39717e88-b638-4eea-8d03-66ae082576d4",
                column: "ConcurrencyStamp",
                value: "90957b9f-44e1-4560-8e60-52ee2ba1b166");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ac2ee9b-a1e1-4c88-89f9-3a0e84277858",
                column: "ConcurrencyStamp",
                value: "60d4c513-407f-41ba-9f09-bd1b88e5b257");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26a33fbd-cd1b-4b69-a1c9-e0e49369614d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7882f1c6-d389-4507-b455-807d35b4a9bd", "AQAAAAEAACcQAAAAEMcqo8V+QJyOFstfz3XlrsDEu4MUf0dIZGhLj4KITWNBwBRrYk6dgtpjWh+HX9Um6w==", "278fe9fe-b118-4878-af45-604c0fc93be0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "344c7353-8798-4d33-93d4-55ca31fac122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55034693-a7af-4bab-9f4d-4638f7e70f23", "AQAAAAEAACcQAAAAEGHRTrEK6Zy4ezOiUNvyxClmM1QqyZ/qBlaGvkrbrgCeyV8e60m+PgizEMnyxszbig==", "a82f245d-9a14-4b21-88d4-374a19054146" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8518), new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8564), new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8315), new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8355), new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8638), new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8642), new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8646), new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8649), new DateTime(2022, 2, 4, 14, 44, 54, 384, DateTimeKind.Local).AddTicks(8651) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39717e88-b638-4eea-8d03-66ae082576d4",
                column: "ConcurrencyStamp",
                value: "f45883f4-a2a2-4f47-88c7-a9f78c227c22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ac2ee9b-a1e1-4c88-89f9-3a0e84277858",
                column: "ConcurrencyStamp",
                value: "e5e3d1c0-957a-481b-8c5f-3d6dcb4914cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26a33fbd-cd1b-4b69-a1c9-e0e49369614d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ded21c9a-924e-4edb-a8bf-acbf1ae2dfb5", "AQAAAAEAACcQAAAAEO122myY87TBcbgrBXMUnkJjkB+1g9ct+6QKIoYAUWw4z6Mn8dsODfvfvb1SkZO62g==", "29e75b5f-e30a-4b24-938e-0c8dfe45a7b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "344c7353-8798-4d33-93d4-55ca31fac122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcc8573f-b55b-4f30-8ecd-064aafd2cc54", "AQAAAAEAACcQAAAAEGL5sGhhat+T249sLdAqHiFu7iCUXSY7kbZKm261+0yRTyUpxBhDwC+DXwGPM0As7Q==", "e179527b-7cbf-42b0-835c-e880f60a0e33" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(1118), new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(1127), new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(705), new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(751), new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(1380), new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(1389), new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(1394), new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(1400), new DateTime(2022, 1, 17, 17, 28, 1, 45, DateTimeKind.Local).AddTicks(1403) });
        }
    }
}
