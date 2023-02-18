using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetinyAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFieldforOrderandOwner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Owners",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Owners");
        }
    }
}
