using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurdUsingRepoDI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depts",
                columns: table => new
                {
                    DeptId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depts", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "Emps",
                columns: table => new
                {
                    EmpId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpMobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeptId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emps", x => x.EmpId);
                    table.ForeignKey(
                        name: "FK_Emps_Depts_DeptId",
                        column: x => x.DeptId,
                        principalTable: "Depts",
                        principalColumn: "DeptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emps_DeptId",
                table: "Emps",
                column: "DeptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emps");

            migrationBuilder.DropTable(
                name: "Depts");
        }
    }
}
