using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetsFIle.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addPetType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Pets");

            migrationBuilder.CreateTable(
                name: "PetTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetTypes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetTypes");

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Pets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
