﻿// <auto-generated />
using CurdUsingRepoDI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CurdUsingRepoDI.Migrations
{
    [DbContext(typeof(ClassContext))]
    [Migration("20240321124256_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CurdUsingRepoDI.Models.Dept", b =>
                {
                    b.Property<long>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("DeptId"));

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptId");

                    b.ToTable("Depts");
                });

            modelBuilder.Entity("CurdUsingRepoDI.Models.Emp", b =>
                {
                    b.Property<long>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("EmpId"));

                    b.Property<long>("DeptId")
                        .HasColumnType("bigint");

                    b.Property<string>("EmpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpEmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpMobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("EmpSalary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmpId");

                    b.HasIndex("DeptId");

                    b.ToTable("Emps");
                });

            modelBuilder.Entity("CurdUsingRepoDI.Models.Emp", b =>
                {
                    b.HasOne("CurdUsingRepoDI.Models.Dept", "Dept")
                        .WithMany("Emps")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dept");
                });

            modelBuilder.Entity("CurdUsingRepoDI.Models.Dept", b =>
                {
                    b.Navigation("Emps");
                });
#pragma warning restore 612, 618
        }
    }
}
