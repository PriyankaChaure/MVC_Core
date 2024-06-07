using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core_Exam.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "table_brand",
                columns: table => new
                {
                    brandid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brandname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brandaddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_table_brand", x => x.brandid);
                });

            migrationBuilder.CreateTable(
                name: "table_mfg",
                columns: table => new
                {
                    mfgid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mfgname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mobileno = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_table_mfg", x => x.mfgid);
                });

            migrationBuilder.CreateTable(
                name: "table_autoparts",
                columns: table => new
                {
                    autopartsid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    autopartname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mfgid = table.Column<long>(type: "bigint", nullable: false),
                    partdesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_table_autoparts", x => x.autopartsid);
                    table.ForeignKey(
                        name: "FK_table_autoparts_table_mfg_mfgid",
                        column: x => x.mfgid,
                        principalTable: "table_mfg",
                        principalColumn: "mfgid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "table_car",
                columns: table => new
                {
                    carid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brandid = table.Column<long>(type: "bigint", nullable: false),
                    autopartsid = table.Column<long>(type: "bigint", nullable: false),
                    partprice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    qty = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_table_car", x => x.carid);
                    table.ForeignKey(
                        name: "FK_table_car_table_autoparts_autopartsid",
                        column: x => x.autopartsid,
                        principalTable: "table_autoparts",
                        principalColumn: "autopartsid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_table_car_table_brand_brandid",
                        column: x => x.brandid,
                        principalTable: "table_brand",
                        principalColumn: "brandid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_table_autoparts_mfgid",
                table: "table_autoparts",
                column: "mfgid");

            migrationBuilder.CreateIndex(
                name: "IX_table_car_autopartsid",
                table: "table_car",
                column: "autopartsid");

            migrationBuilder.CreateIndex(
                name: "IX_table_car_brandid",
                table: "table_car",
                column: "brandid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "table_car");

            migrationBuilder.DropTable(
                name: "table_autoparts");

            migrationBuilder.DropTable(
                name: "table_brand");

            migrationBuilder.DropTable(
                name: "table_mfg");
        }
    }
}
