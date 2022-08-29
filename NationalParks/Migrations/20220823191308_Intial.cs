using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NationalParks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Location = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    CampingAllowed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ParkFee = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalParks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "NationalParks",
                columns: new[] { "ParkId", "CampingAllowed", "Location", "Name", "ParkFee" },
                values: new object[,]
                {
                    { 1, true, "Wyoming USA", "Yellowstone National Park", 25 },
                    { 2, false, "Arizona USA", "Grand Canyon National Park", 20 },
                    { 3, false, "South Dakota USA", "Badlands National Park", 35 },
                    { 4, true, "California USA", "Yosemite National Park", 25 },
                    { 5, true, "Alaska USA", "Denali National Park", 35 },
                    { 6, true, "Maine USA", "Acadia National Park", 25 },
                    { 7, false, "Utah USA", "Arches National Park", 20 },
                    { 8, true, "Montana USA", "Glacier National Park", 35 },
                    { 9, true, "Colorado USA", "Grand Teton National Park", 25 },
                    { 10, true, "Utah USA", "Zion National Park", 35 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NationalParks");
        }
    }
}
