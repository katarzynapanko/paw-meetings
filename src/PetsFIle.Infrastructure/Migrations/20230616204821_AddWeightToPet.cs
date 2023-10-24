using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetsFIle.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddWeightToPet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Pets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Pets");
        }
    }
}
