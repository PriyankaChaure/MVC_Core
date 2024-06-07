using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace prachi_exam_core.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmpId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "EmpSalarys",
                columns: table => new
                {
                    EmpSalaryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmpId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpSalarys", x => x.EmpSalaryId);
                    table.ForeignKey(
                        name: "FK_EmpSalarys_Employees_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employees",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalaryAdditions",
                columns: table => new
                {
                    SalaryAdditionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<long>(type: "bigint", nullable: false),
                    AdditionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryAdditions", x => x.SalaryAdditionId);
                    table.ForeignKey(
                        name: "FK_SalaryAdditions_Employees_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employees",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "salayDeductions",
                columns: table => new
                {
                    SalaryDeductionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<long>(type: "bigint", nullable: false),
                    DeductionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeductionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salayDeductions", x => x.SalaryDeductionId);
                    table.ForeignKey(
                        name: "FK_salayDeductions_Employees_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employees",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpSalarys_EmpId",
                table: "EmpSalarys",
                column: "EmpId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryAdditions_EmpId",
                table: "SalaryAdditions",
                column: "EmpId");

            migrationBuilder.CreateIndex(
                name: "IX_salayDeductions_EmpId",
                table: "salayDeductions",
                column: "EmpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpSalarys");

            migrationBuilder.DropTable(
                name: "SalaryAdditions");

            migrationBuilder.DropTable(
                name: "salayDeductions");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
