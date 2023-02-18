using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetinyAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateAnimalType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_AnimalTypes_AnimalTypeId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_AnimalTypeId",
                table: "Animals");

            migrationBuilder.AlterColumn<int>(
                name: "AnimalTypeId",
                table: "Animals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_AnimalTypeId",
                table: "Animals",
                column: "AnimalTypeId",
                unique: true,
                filter: "[AnimalTypeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AnimalTypes_AnimalTypeId",
                table: "Animals",
                column: "AnimalTypeId",
                principalTable: "AnimalTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_AnimalTypes_AnimalTypeId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_AnimalTypeId",
                table: "Animals");

            migrationBuilder.AlterColumn<int>(
                name: "AnimalTypeId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_AnimalTypeId",
                table: "Animals",
                column: "AnimalTypeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AnimalTypes_AnimalTypeId",
                table: "Animals",
                column: "AnimalTypeId",
                principalTable: "AnimalTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
