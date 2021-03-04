using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Finances.Migrations
{
    public partial class picture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PictureId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Picture",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "4064da45-fd85-49c5-9b68-62bf272fdebb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ae7399d-df65-4b1e-b6b6-5510a0329273", "AQAAAAEAACcQAAAAEJXdQ0/4AxjHU7y4SIP5dT4DrAUgEGUqwuRD5jZ6bwa9BKJv7uIKVMOab52aiMA6wg==" });

            migrationBuilder.UpdateData(
                table: "EntityBase",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 3, 16, 58, 14, 962, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PictureId",
                table: "AspNetUsers",
                column: "PictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Picture_PictureId",
                table: "AspNetUsers",
                column: "PictureId",
                principalTable: "Picture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Picture_PictureId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Picture");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PictureId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PictureId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "bca9bfa5-f727-4515-bbdd-4de7d575ffea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7139f9d4-250d-43e4-8798-949467244c3f", "AQAAAAEAACcQAAAAEJbwWdTb38bJCsFPoG1Gm9mjPlNHnXZcqkngnJ4+8mJLc4TPTDlJ9HSaEuAUovOR9Q==" });

            migrationBuilder.UpdateData(
                table: "EntityBase",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 3, 15, 48, 56, 364, DateTimeKind.Local).AddTicks(2973));
        }
    }
}
