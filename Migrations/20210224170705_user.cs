using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Finances.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "ConcurrencyStamp", "Discriminator", "PasswordHash" },
                values: new object[] { "8de5dc3f-1035-42a1-9864-caedb2555418", "User", "AQAAAAEAACcQAAAAEED6QDQhkf04QYg/2wfvr2aAdCoMa/yUXqCXtisnnQY0x8KkDggIuigk0XzOWrdVfw==" });

            migrationBuilder.UpdateData(
                table: "EntityBase",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 2, 24, 19, 7, 4, 377, DateTimeKind.Local).AddTicks(1656));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "5a89897a-2648-4f6b-9b7d-4033d38d12d5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "360abdfb-45c4-4c2b-874c-d2f9b3af7869", "AQAAAAEAACcQAAAAED1LMWhCCHGGDu/nHy8BK3f/CkgP9Ftg8kAuEVHLRyqbGmUM4VsP0SIippQK6flaYA==" });

            migrationBuilder.UpdateData(
                table: "EntityBase",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 2, 22, 19, 32, 32, 230, DateTimeKind.Local).AddTicks(6586));
        }
    }
}
