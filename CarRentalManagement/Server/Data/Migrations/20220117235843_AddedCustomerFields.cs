using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedCustomerFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39717e88-b638-4eea-8d03-66ae082576d4",
                column: "ConcurrencyStamp",
                value: "9fa38c0f-785f-4ef3-9433-96a943fe9e24");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ac2ee9b-a1e1-4c88-89f9-3a0e84277858",
                column: "ConcurrencyStamp",
                value: "f29abd64-ce77-4269-85c5-5806bd6cbdd9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26a33fbd-cd1b-4b69-a1c9-e0e49369614d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d163c955-e780-411b-9876-e88dc48d9859", "AQAAAAEAACcQAAAAEN5Caq3V5FeQMvYjW+T5jXKnFxqsbPS2f2QteuAUm6CCQ+kQaIl+e+uV5oOGbRpEVA==", "a83721ad-0508-4194-8780-dbcbc515876a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "344c7353-8798-4d33-93d4-55ca31fac122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fd3cbf3-e4da-4d88-9b06-7778a91a28c6", "AQAAAAEAACcQAAAAEF1VXJO9Pjmmzy2oQIdAH043POTKl4ZyfrOxN7yiCB1xgAvLrb2Yu4lhMOZ9lSoVmg==", "64f53c4c-488c-43c6-bc5d-304cfc08772b" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(3178), new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(3184), new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(2931), new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(2980), new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(3425), new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(3448), new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(3451), new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(3455), new DateTime(2022, 1, 17, 16, 52, 52, 719, DateTimeKind.Local).AddTicks(3456) });
        }
    }
}
