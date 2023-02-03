using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetEcommerce.DAL.Migrations
{
    public partial class deneme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 3, 14, 46, 56, 664, DateTimeKind.Local).AddTicks(4311), 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 3, 14, 46, 56, 665, DateTimeKind.Local).AddTicks(2938), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 3, 14, 46, 56, 665, DateTimeKind.Local).AddTicks(3372), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 3, 14, 46, 56, 665, DateTimeKind.Local).AddTicks(6914), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 1, 11, 44, 36, 620, DateTimeKind.Local).AddTicks(66), 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 1, 11, 44, 36, 620, DateTimeKind.Local).AddTicks(8622), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 1, 11, 44, 36, 620, DateTimeKind.Local).AddTicks(9027), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 1, 11, 44, 36, 621, DateTimeKind.Local).AddTicks(2578), 0 });
        }
    }
}
