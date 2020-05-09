using Microsoft.EntityFrameworkCore.Migrations;

namespace Stories.Migrations
{
    public partial class RemoveTypeToStoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Stories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Stories",
                type: "text",
                nullable: true);
        }
    }
}
