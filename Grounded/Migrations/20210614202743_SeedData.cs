using Microsoft.EntityFrameworkCore.Migrations;

namespace Grounded.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ResourceId", "ResourceAdvice", "ResourceColor", "ResourceExercise", "ResourceImage", "ResourceLink", "ResourceMeditation", "ResourceMusic", "ResourceQuote" },
                values: new object[] { 1, "Get wasted", "Orange", "Everyday is a half day if you just fucking leave.", "Lets see if this loads", "Some url", "With your eyes closed, close your eyes.", "Api search query", "Let everything happen to you, beauty and terror, just keep going, no feeling is final." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1);
        }
    }
}
