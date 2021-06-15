using Microsoft.EntityFrameworkCore.Migrations;

namespace Grounded.Migrations
{
    public partial class MigrationUpdateDay2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResourceMeditation",
                table: "Resources");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1,
                columns: new[] { "ResourceName", "ResourceQuote" },
                values: new object[] { "Anxiety", "It's okay to talk about mental health issues. It's okay to admit that you have anxiety. It doesn't take away from your power. It's totally normal. - Torrey DeVitto" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ResourceId", "ResourceColor", "ResourceExercise", "ResourceImage", "ResourceLink", "ResourceMusic", "ResourceName", "ResourceQuote" },
                values: new object[,]
                {
                    { 2, "", "", "../", "", "", "Guilt", "I think the saddest thing is how people take on guilt and blame that isn't theirs or doesn't belong to them, and how hard it is to forgive yourself. - Wunmi Mosaku" },
                    { 3, "", "", "", "", "", "Depression", "My mental health problems are real and they are valid. I will not judge myself for the bad days when I can barely get out of bed. I will not make myself feel worse because someone else appears to be handling their mental illness better than I am handling mine. Recovery is not a competition. - Matt Joseph Diaz" },
                    { 4, "blue-green", "5, 4, 3, 2, 1 Mindfulness exercise", "", "https://drsarahallen.com/7-ways-to-calm/", "https://open.spotify.com/track/6epIhVc3Zn6AUZ27EsOLZt?si=5d8e25c2b00d4d6e", "Restless", "Sometimes the most important thing in a whole day is the rest we take between two deep breaths. – Etty Hillesum." },
                    { 5, "Lavender", "Box Breathing", "", "https://www.healthline.com/health/box-breathing", "https://open.spotify.com/track/4z0X671zhnwxj9YklzDyhv?si=abf5c8e6129b498f", "Fear", "Fears are nothing more than a state of mind. - Napoleon Hill" },
                    { 6, "", "", "", "", "", "Depression", "" },
                    { 7, "", "", "", "", "", "Depression", "" },
                    { 8, "", "", "", "", "", "Depression", "" },
                    { 9, "", "", "", "", "", "Depression", "" },
                    { 10, "", "", "", "", "", "Depression", "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 10);

            migrationBuilder.AddColumn<string>(
                name: "ResourceMeditation",
                table: "Resources",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1,
                columns: new[] { "ResourceMeditation", "ResourceName", "ResourceQuote" },
                values: new object[] { "With your eyes closed, close your eyes.", "TestName", "Let everything happen to you, beauty and terror, just keep going, no feeling is final." });
        }
    }
}
