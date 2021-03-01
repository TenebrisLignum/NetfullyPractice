using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Finances.Migrations
{
    public partial class family : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "EntityBase",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Family",
                table: "EntityBase",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Family",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Family", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FamilyUser",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    FamilyId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyUser", x => new { x.UserId, x.FamilyId });
                    table.ForeignKey(
                        name: "FK_FamilyUser_Family_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Family",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FamilyUser_FamilyId",
                table: "FamilyUser",
                column: "FamilyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FamilyUser");

            migrationBuilder.DropTable(
                name: "Family");

            migrationBuilder.DropColumn(
                name: "About",
                table: "EntityBase");

            migrationBuilder.DropColumn(
                name: "Family",
                table: "EntityBase");

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
                column: "DateAdded",
                value: new DateTime(2021, 2, 25, 16, 9, 6, 313, DateTimeKind.Local).AddTicks(9662));
        }
    }
}
