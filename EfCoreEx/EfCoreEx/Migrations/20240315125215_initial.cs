using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreEx.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorytbl",
                columns: table => new
                {
                    CategoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorytbl", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "producttbl",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Productname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MfgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producttbl", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_producttbl_categorytbl_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categorytbl",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_producttbl_CategoryId",
                table: "producttbl",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "producttbl");

            migrationBuilder.DropTable(
                name: "categorytbl");
        }
    }
}
