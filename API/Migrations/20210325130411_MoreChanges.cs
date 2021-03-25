using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class MoreChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecipientCollege",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderCollege",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipientCollege",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderCollege",
                table: "Messages");
        }
    }
}
