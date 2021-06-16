using Microsoft.EntityFrameworkCore.Migrations;

namespace Grounded.Migrations
{
    public partial class SongMigrationTest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1,
                column: "ResourceMusic",
                value: "https://open.spotify.com/embed/track/4OHJmCwMAexvmRsBWToZMP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1,
                column: "ResourceMusic",
                value: "https://open.spotify.com/track/2sANicYotJYrO53QdGHOV5?si=f25fff5a734a495f");
        }
    }
}
