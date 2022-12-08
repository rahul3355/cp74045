using Microsoft.EntityFrameworkCore.Migrations;

namespace CP74045.Migrations
{
    public partial class EmployeePicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeePicture",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeePicture",
                table: "Employees");
        }
    }
}
