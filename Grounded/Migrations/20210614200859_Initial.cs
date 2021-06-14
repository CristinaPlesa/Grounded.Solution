using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Grounded.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    ResourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ResourceQuote = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ResourceMeditation = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ResourceAdvice = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ResourceExercise = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ResourceColor = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ResourceMusic = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ResourceImage = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ResourceLink = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.ResourceId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resources");
        }
    }
}
