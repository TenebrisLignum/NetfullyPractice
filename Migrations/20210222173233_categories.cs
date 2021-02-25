using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Finances.Migrations
{
    public partial class categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("34314e98-fad1-4033-a748-1e5bc57a3079"), "Продукти" });

            migrationBuilder.UpdateData(
                table: "EntityBase",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 2, 22, 19, 32, 32, 230, DateTimeKind.Local).AddTicks(6586));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "4bb15fe2-4fba-4d55-9526-0febee3379d3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b19d0fea-f36d-4bb0-9565-e1b080104636", "AQAAAAEAACcQAAAAEHxC5p8MG5CfFSFebD4oAcwXEvGekOz83VZMs7GMPvE0gnea3tyeknRZosuGi9urEQ==" });

            migrationBuilder.UpdateData(
                table: "EntityBase",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 2, 9, 21, 16, 56, 742, DateTimeKind.Local).AddTicks(6407));
        }
    }
}
