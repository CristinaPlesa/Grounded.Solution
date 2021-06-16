using Microsoft.EntityFrameworkCore.Migrations;

namespace Grounded.Migrations
{
    public partial class UpdateMusicLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 8,
                column: "ResourceMusic",
                value: "https://open.spotify.com/embed/track/2tgw0vmJDgckHwW2PdYTGo?si=80bd03eb43244f3b?theme=0");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 9,
                column: "ResourceMusic",
                value: "https://open.spotify.com/embed/track/7ckJgqAp6jAUSJ9Av2t9LY?si=9a48827d174f4587?theme=0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 8,
                column: "ResourceMusic",
                value: "Let’s Dance David Bowie: https://open.spotify.com/embed/track/2tgw0vmJDgckHwW2PdYTGo?si=80bd03eb43244f3b?theme=0");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 9,
                column: "ResourceMusic",
                value: "Lila Rodriguez Jr.: https://open.spotify.com/embed/track/7ckJgqAp6jAUSJ9Av2t9LY?si=9a48827d174f4587?theme=0");
        }
    }
}
