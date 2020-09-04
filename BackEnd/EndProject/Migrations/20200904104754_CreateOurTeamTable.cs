using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EndProject.Migrations
{
    public partial class CreateOurTeamTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OurTeams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fullname = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    TireandWheelServices = table.Column<int>(nullable: false),
                    LubeOilandFilters = table.Column<int>(nullable: false),
                    BeltsandHoses = table.Column<int>(nullable: false),
                    EngineDiagnostics = table.Column<int>(nullable: false),
                    BrakeRepair = table.Column<int>(nullable: false),
                    AirConditioning = table.Column<int>(nullable: false),
                    FacebookAddress = table.Column<string>(nullable: false),
                    TwitterAddress = table.Column<string>(nullable: false),
                    LinkedinAddress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurTeams", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OurTeams");
        }
    }
}
