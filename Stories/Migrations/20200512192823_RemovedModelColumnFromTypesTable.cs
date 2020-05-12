using Microsoft.EntityFrameworkCore.Migrations;

namespace Stories.Migrations
{
    public partial class RemovedModelColumnFromTypesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "Types");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Types",
                type: "text",
                nullable: true);
        }
    }
}
