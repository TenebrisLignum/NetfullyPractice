using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Finances.Migrations
{
    public partial class pictureupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<byte[]>(
                name: "Avatar",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "ee51afcf-1dec-4452-98d0-b9dc94d51bbd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "75d62d87-31c2-4433-b166-b1bd0b63666d", "AQAAAAEAACcQAAAAEHfuyfIs3Tnh4hpD4nof0yKMrlN9w4o1Fm0yszD48pSGaVh6lbopMIP9iBO1iMZAtQ==" });

            migrationBuilder.UpdateData(
                table: "EntityBase",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 3, 17, 54, 47, 768, DateTimeKind.Local).AddTicks(9077));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<Guid>(
                name: "PictureId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Picture",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
    }
}
