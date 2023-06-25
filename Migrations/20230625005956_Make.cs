using Microsoft.EntityFrameworkCore.Migrations;

namespace cSharp2022.Migrations
{
    public partial class Make : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Make",
                table: "Gears",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Make",
                table: "Gears");
        }
    }
}
