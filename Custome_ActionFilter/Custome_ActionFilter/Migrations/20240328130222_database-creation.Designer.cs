﻿// <auto-generated />
using System;
using Custome_ActionFilter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Custome_ActionFilter.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240328130222_database-creation")]
    partial class databasecreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Custome_ActionFilter.Models.ActionLog", b =>
                {
                    b.Property<long>("ActionLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ActionLogId"));

                    b.Property<DateTime>("ActionLogDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ActionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ControllerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActionLogId");

                    b.ToTable("Log");
                });
#pragma warning restore 612, 618
        }
    }
}
