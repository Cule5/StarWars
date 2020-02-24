using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class added_friendship5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CharacterAId",
                table: "Friendships",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterBId",
                table: "Friendships",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_CharacterAId",
                table: "Friendships",
                column: "CharacterAId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_CharacterBId",
                table: "Friendships",
                column: "CharacterBId");

            migrationBuilder.AddForeignKey(
                name: "FK_Friendships_Characters_CharacterAId",
                table: "Friendships",
                column: "CharacterAId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendships_Characters_CharacterBId",
                table: "Friendships",
                column: "CharacterBId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friendships_Characters_CharacterAId",
                table: "Friendships");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendships_Characters_CharacterBId",
                table: "Friendships");

            migrationBuilder.DropIndex(
                name: "IX_Friendships_CharacterAId",
                table: "Friendships");

            migrationBuilder.DropIndex(
                name: "IX_Friendships_CharacterBId",
                table: "Friendships");

            migrationBuilder.DropColumn(
                name: "CharacterAId",
                table: "Friendships");

            migrationBuilder.DropColumn(
                name: "CharacterBId",
                table: "Friendships");
        }
    }
}
