using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetinyAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateimageColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Animals");
        }
    }
}
