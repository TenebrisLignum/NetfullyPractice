using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Finances.Migrations
{
    public partial class entitybasetheuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TheUser",
                table: "EntityBase",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "d6fc6232-c957-496a-9e15-4fc910152864");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99eecbb4-4614-4b0c-9573-bec4b3a9ceac", "AQAAAAEAACcQAAAAEAn0N97VXExsR+zZsGlro3Eg6UowXu3cy+7iFPhxuOqvL7yudCgxRc7k7d9z/fqPnQ==" });

            migrationBuilder.UpdateData(
                table: "EntityBase",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                columns: new[] { "DateAdded", "TheUser" },
                values: new object[] { new DateTime(2021, 2, 25, 16, 9, 6, 313, DateTimeKind.Local).AddTicks(9662), "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TheUser",
                table: "EntityBase");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "a32548a7-8775-4ede-8445-a479b91ec006");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8de5dc3f-1035-42a1-9864-caedb2555418", "AQAAAAEAACcQAAAAEED6QDQhkf04QYg/2wfvr2aAdCoMa/yUXqCXtisnnQY0x8KkDggIuigk0XzOWrdVfw==" });

            migrationBuilder.UpdateData(
                table: "EntityBase",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 2, 24, 19, 7, 4, 377, DateTimeKind.Local).AddTicks(1656));
        }
    }
}
