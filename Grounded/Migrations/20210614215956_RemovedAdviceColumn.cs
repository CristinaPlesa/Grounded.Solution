using Microsoft.EntityFrameworkCore.Migrations;

namespace Grounded.Migrations
{
    public partial class RemovedAdviceColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResourceAdvice",
                table: "Resources",
                newName: "ResourceName");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1,
                columns: new[] { "ResourceLink", "ResourceMusic", "ResourceName" },
                values: new object[] { "https://www.sadanduseless.com/legs-or-sausages-gallery/", "cheerful", "TestName" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResourceName",
                table: "Resources",
                newName: "ResourceAdvice");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1,
                columns: new[] { "ResourceAdvice", "ResourceLink", "ResourceMusic" },
                values: new object[] { "Get wasted", "Some url", "Api search query" });
        }
    }
}
