using Microsoft.EntityFrameworkCore.Migrations;

namespace Grounded.Migrations
{
    public partial class UpdateSeededImageLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "Sunset over hills", "https://images.unsplash.com/photo-1500534623283-312aade485b7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1950&q=80" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 2,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "Photo of feather and hand overlooking lake.", "https://images.unsplash.com/photo-1531951657915-02db328ae9d1?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=700&q=80" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 3,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "Close up of leaves", "https://images.unsplash.com/photo-1622136061320-6fb380ea45ae?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 4,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "Trees", "https://images.unsplash.com/photo-1441974231531-c6227db76b6e?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1051&q=80" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 5,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "Birds eye view of ocean", "https://images.unsplash.com/photo-1540206395-68808572332f?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=562&q=80" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 6,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "Night Sky and mountains", "https://wallpapercave.com/wp/wp5986661.jpg" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 7,
                column: "AltDescription",
                value: "Night Sky and Mountains");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 8,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "Field with Sunset", "https://images.unsplash.com/photo-1614107707379-283a65774553?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=2250&q=80" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 9,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "Two Sapling Plants", "https://images.unsplash.com/photo-1457530378978-8bac673b8062?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1950&q=80" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 10,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "Pacific City, Oregon", "https://images.unsplash.com/photo-1613149778673-37890fec94ca?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1950&q=80" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "Image of sunset over hills", "https://unsplash.com/photos/dQejX2ucPBs" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 2,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "", "https://unsplash.com/photos/Vs_zkj1sEHc" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 3,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "", "https://unsplash.com/photos/CtLx4qCdhf8" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 4,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 5,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 6,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "", "" });

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
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "", "https://unsplash.com/photos/efe3IfUqnfY" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 9,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "", "https://unsplash.com/photos/ruQHpukrN7c" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 10,
                columns: new[] { "AltDescription", "ResourceImage" },
                values: new object[] { "", "https://unsplash.com/photos/-SbQgia5ggg" });
        }
    }
}
