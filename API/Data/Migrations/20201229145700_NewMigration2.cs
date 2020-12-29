using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class NewMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExtrCurricular",
                table: "HsPreps",
                newName: "ExtraCurricular");

            migrationBuilder.AlterColumn<float>(
                name: "GPA",
                table: "HsPreps",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "HsPreps",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CompanyDescription",
                table: "EmpOpps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Athletics",
                table: "CollegePreps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "College",
                table: "CollegePreps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraCurricular",
                table: "CollegePreps",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "HsPreps");

            migrationBuilder.DropColumn(
                name: "CompanyDescription",
                table: "EmpOpps");

            migrationBuilder.DropColumn(
                name: "Athletics",
                table: "CollegePreps");

            migrationBuilder.DropColumn(
                name: "College",
                table: "CollegePreps");

            migrationBuilder.DropColumn(
                name: "ExtraCurricular",
                table: "CollegePreps");

            migrationBuilder.RenameColumn(
                name: "ExtraCurricular",
                table: "HsPreps",
                newName: "ExtrCurricular");

            migrationBuilder.AlterColumn<string>(
                name: "GPA",
                table: "HsPreps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
