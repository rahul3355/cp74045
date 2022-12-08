using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CP74045.Migrations
{
    public partial class Project01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectName = table.Column<string>(nullable: true),
                    ProjectDurationInDays = table.Column<int>(nullable: false),
                    ProjectType = table.Column<string>(nullable: true),
                    BackendRequirements = table.Column<string>(nullable: true),
                    FrontendRequirements = table.Column<string>(nullable: true),
                    ProjectBudget = table.Column<int>(nullable: false),
                    ProjectDatabaseUsed = table.Column<string>(nullable: true),
                    ProjectInfo = table.Column<string>(nullable: true),
                    ProjectStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
