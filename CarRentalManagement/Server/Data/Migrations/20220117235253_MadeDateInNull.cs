using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class MadeDateInNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
