using Microsoft.EntityFrameworkCore.Migrations;

namespace Stories.Migrations
{
    public partial class AddedStoryToBusinessRulesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StoryId",
                table: "BusinessRules",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRules_StoryId",
                table: "BusinessRules",
                column: "StoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessRules_Stories_StoryId",
                table: "BusinessRules",
                column: "StoryId",
                principalTable: "Stories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessRules_Stories_StoryId",
                table: "BusinessRules");

            migrationBuilder.DropIndex(
                name: "IX_BusinessRules_StoryId",
                table: "BusinessRules");

            migrationBuilder.DropColumn(
                name: "StoryId",
                table: "BusinessRules");
        }
    }
}
