using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class _2ndnewinitialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HomeTown",
                table: "Users",
                newName: "Hometown");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Hometown",
                table: "Users",
                newName: "HomeTown");
        }
    }
}
