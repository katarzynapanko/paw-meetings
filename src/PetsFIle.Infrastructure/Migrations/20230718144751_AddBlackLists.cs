using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetsFIle.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddBlackLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OwnerBlackLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerBlackLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OwnerBlackLists_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OwnerBlackLists_PetTypes_PetTypeId",
                        column: x => x.PetTypeId,
                        principalTable: "PetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PetBlackList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetBlackList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetBlackList_PetTypes_PetTypeId",
                        column: x => x.PetTypeId,
                        principalTable: "PetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PetBlackList_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OwnerBlackLists_OwnerId",
                table: "OwnerBlackLists",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerBlackLists_PetTypeId",
                table: "OwnerBlackLists",
                column: "PetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PetBlackList_PetId",
                table: "PetBlackList",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_PetBlackList_PetTypeId",
                table: "PetBlackList",
                column: "PetTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OwnerBlackLists");

            migrationBuilder.DropTable(
                name: "PetBlackList");
        }
    }
}
