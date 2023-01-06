using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollectiveStartUpClub.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StartUpClubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvestorSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ASourceOfInspiration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarketOpportunity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YourCompetitors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentPhaseOfTheProject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatentTrademarkApplicationDetailsOfTheProject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YourGrowthStrategies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartUpClubs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StartUpClubs");
        }
    }
}
