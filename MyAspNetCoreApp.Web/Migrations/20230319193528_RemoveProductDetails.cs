using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAspNetCoreApp.Web.Migrations
{
    public partial class RemoveProductDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Expire",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsPublish",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Expire",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublish",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "Products",
                type: "datetime2",
                nullable: true);
        }
    }
}
