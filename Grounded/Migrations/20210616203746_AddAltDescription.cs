using Microsoft.EntityFrameworkCore.Migrations;

namespace Grounded.Migrations
{
    public partial class AddAltDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AltDescription",
                table: "Resources",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1,
                column: "AltDescription",
                value: "Image of sunset over hills");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 2,
                column: "AltDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 3,
                column: "AltDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 4,
                column: "AltDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 5,
                column: "AltDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 6,
                column: "AltDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 7,
                column: "AltDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 8,
                column: "AltDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 9,
                column: "AltDescription",
                value: "");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 10,
                column: "AltDescription",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AltDescription",
                table: "Resources");
        }
    }
}
