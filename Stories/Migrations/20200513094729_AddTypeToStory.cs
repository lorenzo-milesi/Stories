using Microsoft.EntityFrameworkCore.Migrations;

namespace Stories.Migrations
{
    public partial class AddTypeToStory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Stories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stories_TypeId",
                table: "Stories",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_Types_TypeId",
                table: "Stories",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stories_Types_TypeId",
                table: "Stories");

            migrationBuilder.DropIndex(
                name: "IX_Stories_TypeId",
                table: "Stories");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Stories");
        }
    }
}
