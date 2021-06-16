using Microsoft.EntityFrameworkCore.Migrations;

namespace Grounded.Migrations
{
    public partial class UpdatePhotosAndImageLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1,
                column: "ResourceMusic",
                value: "https://open.spotify.com/embed/track/4OHJmCwMAexvmRsBWToZMP?theme=0");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 2,
                column: "ResourceMusic",
                value: "https://open.spotify.com/embed/track/4GSDkZt7GcmzBWmsMcpaVO?si=f5892c71714d4dc4?theme=0");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 3,
                column: "ResourceMusic",
                value: "https://open.spotify.com/embed/track/25RDHbzKzGSUefENv5uz9M?si=61589008ed6341f2?theme=0");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 4,
                columns: new[] { "ResourceImage", "ResourceMusic" },
                values: new object[] { "https://images.unsplash.com/photo-1562569665-84986a052d8c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=700&q=80", "https://open.spotify.com/embed/track/6epIhVc3Zn6AUZ27EsOLZt?si=5d8e25c2b00d4d6e?theme=0" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 5,
                columns: new[] { "ResourceImage", "ResourceMusic" },
                values: new object[] { "https://images.unsplash.com/photo-1618987989259-78151746dcab?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1050&q=80", "https://open.spotify.com/embed/track/4z0X671zhnwxj9YklzDyhv?si=abf5c8e6129b498f?theme=0" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 6,
                column: "ResourceMusic",
                value: "https://open.spotify.com/embed/track/20QeXpfRB5GWK46PlXr1In?si=86b09455a29d41b3?theme=0");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 7,
                column: "ResourceMusic",
                value: "https://open.spotify.com/embed/track/18ETUDvgfFPonyIjOwRFGu?si=3dc30ea49cff4f00?theme=0");

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

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 10,
                column: "ResourceMusic",
                value: "https://open.spotify.com/embed/track/0VjIjW4GlUZAMYd2vXMi3b?si=9abb1d91e13e45e7?theme=0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1,
                column: "ResourceMusic",
                value: "https://open.spotify.com/embed/track/4OHJmCwMAexvmRsBWToZMP");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 2,
                column: "ResourceMusic",
                value: "https://open.spotify.com/track/4GSDkZt7GcmzBWmsMcpaVO?si=f5892c71714d4dc4");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 3,
                column: "ResourceMusic",
                value: "https://open.spotify.com/track/25RDHbzKzGSUefENv5uz9M?si=61589008ed6341f2");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 4,
                columns: new[] { "ResourceImage", "ResourceMusic" },
                values: new object[] { "https://images.unsplash.com/photo-1441974231531-c6227db76b6e?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1051&q=80", "https://open.spotify.com/track/6epIhVc3Zn6AUZ27EsOLZt?si=5d8e25c2b00d4d6e" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 5,
                columns: new[] { "ResourceImage", "ResourceMusic" },
                values: new object[] { "https://images.unsplash.com/photo-1540206395-68808572332f?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=562&q=80", "https://open.spotify.com/track/4z0X671zhnwxj9YklzDyhv?si=abf5c8e6129b498f" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 6,
                column: "ResourceMusic",
                value: "https://open.spotify.com/track/20QeXpfRB5GWK46PlXr1In?si=86b09455a29d41b3");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 7,
                column: "ResourceMusic",
                value: "https://open.spotify.com/track/18ETUDvgfFPonyIjOwRFGu?si=3dc30ea49cff4f00");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 8,
                column: "ResourceMusic",
                value: "Let’s Dance David Bowie: https://open.spotify.com/track/2tgw0vmJDgckHwW2PdYTGo?si=80bd03eb43244f3b");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 9,
                column: "ResourceMusic",
                value: "Lila Rodriguez Jr.: https://open.spotify.com/track/7ckJgqAp6jAUSJ9Av2t9LY?si=9a48827d174f4587");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 10,
                column: "ResourceMusic",
                value: "https://open.spotify.com/track/0VjIjW4GlUZAMYd2vXMi3b?si=9abb1d91e13e45e7");
        }
    }
}
