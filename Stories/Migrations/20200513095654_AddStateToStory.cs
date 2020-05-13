using Microsoft.EntityFrameworkCore.Migrations;

namespace Stories.Migrations
{
    public partial class AddStateToStory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "Stories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stories_StateId",
                table: "Stories",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_States_StateId",
                table: "Stories",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stories_States_StateId",
                table: "Stories");

            migrationBuilder.DropIndex(
                name: "IX_Stories_StateId",
                table: "Stories");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Stories");
        }
    }
}
