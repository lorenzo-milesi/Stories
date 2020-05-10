using Microsoft.EntityFrameworkCore.Migrations;

namespace Stories.Migrations
{
    public partial class ChangedProjectIdForeignKeyInStoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stories_Projects_ProjectId",
                table: "Stories");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Stories",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_Projects_ProjectId",
                table: "Stories",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stories_Projects_ProjectId",
                table: "Stories");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Stories",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_Projects_ProjectId",
                table: "Stories",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
