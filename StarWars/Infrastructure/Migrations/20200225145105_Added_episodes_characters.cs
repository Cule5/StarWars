using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Added_episodes_characters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Characters_CharacterId",
                table: "Episodes");

            migrationBuilder.DropIndex(
                name: "IX_Episodes_CharacterId",
                table: "Episodes");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Episodes");

            migrationBuilder.CreateTable(
                name: "CharacterEpisode",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CharacterId = table.Column<Guid>(nullable: false),
                    EpisodeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterEpisode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterEpisode_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterEpisode_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEpisode_CharacterId",
                table: "CharacterEpisode",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEpisode_EpisodeId",
                table: "CharacterEpisode",
                column: "EpisodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterEpisode");

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "Episodes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_CharacterId",
                table: "Episodes",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Characters_CharacterId",
                table: "Episodes",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
