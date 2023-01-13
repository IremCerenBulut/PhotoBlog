using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoBlog.Data.Migrations
{
    public partial class TagsEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTıme",
                value: new DateTime(2023, 1, 13, 14, 30, 11, 851, DateTimeKind.Local).AddTicks(1426));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTıme",
                value: new DateTime(2023, 1, 13, 14, 24, 42, 953, DateTimeKind.Local).AddTicks(6006));
        }
    }
}
