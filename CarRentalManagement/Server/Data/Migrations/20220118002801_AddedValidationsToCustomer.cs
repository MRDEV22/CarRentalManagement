using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationsToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39717e88-b638-4eea-8d03-66ae082576d4",
                column: "ConcurrencyStamp",
                value: "2906f40d-d063-4321-bc17-534ab8ae96f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ac2ee9b-a1e1-4c88-89f9-3a0e84277858",
                column: "ConcurrencyStamp",
                value: "85945f48-f9d7-458d-8b50-f17fffa4f1a4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26a33fbd-cd1b-4b69-a1c9-e0e49369614d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f28cda84-664f-4093-a82a-02e5552ba64a", "AQAAAAEAACcQAAAAEBBg5c5q9M2I9uh3a2KTNAIvTDO+T4WwmHfc7qi3jQmdr7BIJaWZ7MQt5D9E8eggxw==", "a653a702-6adb-463f-a9b0-effe4f1be7f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "344c7353-8798-4d33-93d4-55ca31fac122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d37fcb66-204c-4e9a-a114-7180f6a8d186", "AQAAAAEAACcQAAAAEHK63WOqSxQ5wEysYWXsfLjWyXjkVoDqAq0yUDI+UYmV0gz08Qybo8fQ8sYhbQogKQ==", "0055c726-e3c1-45ff-a2ff-3d0c75933eba" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(5031), new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(5036), new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(4821), new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(4859), new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(5099), new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(5104), new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(5107), new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(5110), new DateTime(2022, 1, 17, 16, 58, 43, 157, DateTimeKind.Local).AddTicks(5112) });
        }
    }
}
