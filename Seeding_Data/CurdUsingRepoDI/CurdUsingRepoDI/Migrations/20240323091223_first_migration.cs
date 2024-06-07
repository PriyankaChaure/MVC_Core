using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CurdUsingRepoDI.Migrations
{
    /// <inheritdoc />
    public partial class first_migration : Migration
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
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpEmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpMobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Depts",
                columns: new[] { "DeptId", "DeptName" },
                values: new object[,]
                {
                    { 1L, "Cpmputer" },
                    { 2L, "Mechanical" },
                    { 3L, "Civil" },
                    { 4L, "ENTC" }
                });

            migrationBuilder.InsertData(
                table: "Emps",
                columns: new[] { "EmpId", "DeptId", "EmpAddress", "EmpEmailId", "EmpMobileNo", "EmpName", "EmpSalary" },
                values: new object[,]
                {
                    { 1L, 1L, "Pune", "priya@gmail.com", "9876543210", "Priyanka", 9876m },
                    { 2L, 2L, "Pune", "sweety@gmail.com", "9999543210", "Sweety", 9777m },
                    { 3L, 3L, "Pune", "guddi@gmail.com", "9888543210", "Guddi", 9555m }
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
