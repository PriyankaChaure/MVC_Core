using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Core_Ex1.Migrations
{
    /// <inheritdoc />
    public partial class ForiegenKeyChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Cities_CityId",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_CityId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Flights");

            migrationBuilder.CreateTable(
                name: "CityFlights",
                columns: table => new
                {
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    FightsFightId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityFlights", x => new { x.CityId, x.FightsFightId });
                    table.ForeignKey(
                        name: "FK_CityFlights_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityFlights_Flights_FightsFightId",
                        column: x => x.FightsFightId,
                        principalTable: "Flights",
                        principalColumn: "FightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CityFlights_FightsFightId",
                table: "CityFlights",
                column: "FightsFightId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityFlights");

            migrationBuilder.AddColumn<long>(
                name: "CityId",
                table: "Flights",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Flights_CityId",
                table: "Flights",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Cities_CityId",
                table: "Flights",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
