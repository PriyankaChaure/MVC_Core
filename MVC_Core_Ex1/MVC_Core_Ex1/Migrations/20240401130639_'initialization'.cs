using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Core_Ex1.Migrations
{
    /// <inheritdoc />
    public partial class initialization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    FacilityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.FacilityId);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FightId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FightNo = table.Column<long>(type: "bigint", nullable: false),
                    SourceCityId = table.Column<long>(type: "bigint", nullable: false),
                    DestinationCityId = table.Column<long>(type: "bigint", nullable: false),
                    Fair = table.Column<long>(type: "bigint", nullable: false),
                    TravelTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDirect = table.Column<bool>(type: "bit", nullable: false),
                    CityId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FightId);
                    table.ForeignKey(
                        name: "FK_Flights_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightFacilities",
                columns: table => new
                {
                    FlightFeatureId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FightId = table.Column<long>(type: "bigint", nullable: false),
                    FacilityId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightFacilities", x => x.FlightFeatureId);
                    table.ForeignKey(
                        name: "FK_FlightFacilities_Facilities_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facilities",
                        principalColumn: "FacilityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightFacilities_Flights_FightId",
                        column: x => x.FightId,
                        principalTable: "Flights",
                        principalColumn: "FightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightFacilities_FacilityId",
                table: "FlightFacilities",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightFacilities_FightId",
                table: "FlightFacilities",
                column: "FightId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_CityId",
                table: "Flights",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightFacilities");

            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
