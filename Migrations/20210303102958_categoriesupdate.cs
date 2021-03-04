using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Finances.Migrations
{
    public partial class categoriesupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Direction",
                table: "Categories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "645154cb-ac6c-4c62-9baa-f6bcf19fdba6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "863f5f23-7a9e-4a6f-81b1-74bbfa917d80", "AQAAAAEAACcQAAAAEPt/uTBoP1j9vqo31M2Y4hS8PpTpPWtn9hkfkNVkYBeAFx3qy486TL7M1dP6Gi8BxQ==" });

            migrationBuilder.UpdateData(
                table: "EntityBase",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 3, 12, 29, 56, 639, DateTimeKind.Local).AddTicks(3069));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direction",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "2a0ecb3e-c237-42b3-a8d4-fd8237636581");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6625bfc2-fc92-4c53-b796-16bb63f995bc", "AQAAAAEAACcQAAAAEONyzdbUGASEB8PO2kRpFyS8zxwlcTt7PPv+YZRkzNNyoNxd6eu0y+3xzgmjdVQFcQ==" });

            migrationBuilder.UpdateData(
                table: "EntityBase",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 1, 8, 50, 16, 222, DateTimeKind.Local).AddTicks(4450));
        }
    }
}
