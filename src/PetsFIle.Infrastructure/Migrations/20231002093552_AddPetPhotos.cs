using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetsFIle.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPetPhotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OwnerAddress_Owners_OwnerId",
                table: "OwnerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerBlackLists_Owners_OwnerId",
                table: "OwnerBlackLists");

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_PetId",
                table: "Photo",
                column: "PetId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerAddress_Owners_OwnerId",
                table: "OwnerAddress",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerBlackLists_Owners_OwnerId",
                table: "OwnerBlackLists",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OwnerAddress_Owners_OwnerId",
                table: "OwnerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerBlackLists_Owners_OwnerId",
                table: "OwnerBlackLists");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerAddress_Owners_OwnerId",
                table: "OwnerAddress",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerBlackLists_Owners_OwnerId",
                table: "OwnerBlackLists",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id");
        }
    }
}
