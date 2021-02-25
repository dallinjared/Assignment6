using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment5.Migrations
{
    public partial class updatedinitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pages",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pages",
                table: "Books");
        }
    }
}
