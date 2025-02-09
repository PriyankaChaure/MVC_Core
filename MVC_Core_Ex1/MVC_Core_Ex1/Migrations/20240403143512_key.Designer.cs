﻿// <auto-generated />
using MVC_Core_Ex1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_Core_Ex1.Migrations
{
    [DbContext(typeof(ClassContext))]
    [Migration("20240403143512_key")]
    partial class key
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CityFlights", b =>
                {
                    b.Property<long>("CityId")
                        .HasColumnType("bigint");

                    b.Property<long>("FightsFightId")
                        .HasColumnType("bigint");

                    b.HasKey("CityId", "FightsFightId");

                    b.HasIndex("FightsFightId");

                    b.ToTable("CityFlights");
                });

            modelBuilder.Entity("MVC_Core_Ex1.Models.City", b =>
                {
                    b.Property<long>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CityId"));

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("MVC_Core_Ex1.Models.Facility", b =>
                {
                    b.Property<long>("FacilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("FacilityId"));

                    b.Property<string>("FacilityDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacilityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacilityId");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("MVC_Core_Ex1.Models.FlightFacility", b =>
                {
                    b.Property<long>("FlightFeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("FlightFeatureId"));

                    b.Property<long>("FacilityId")
                        .HasColumnType("bigint");

                    b.Property<long>("FightId")
                        .HasColumnType("bigint");

                    b.HasKey("FlightFeatureId");

                    b.HasIndex("FacilityId");

                    b.HasIndex("FightId");

                    b.ToTable("FlightFacilities");
                });

            modelBuilder.Entity("MVC_Core_Ex1.Models.Flights", b =>
                {
                    b.Property<long>("FightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("FightId"));

                    b.Property<long>("DestinationCityId")
                        .HasColumnType("bigint");

                    b.Property<long>("Fair")
                        .HasColumnType("bigint");

                    b.Property<long>("FightNo")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDirect")
                        .HasColumnType("bit");

                    b.Property<long>("SourceCityId")
                        .HasColumnType("bigint");

                    b.Property<string>("TravelTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FightId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("CityFlights", b =>
                {
                    b.HasOne("MVC_Core_Ex1.Models.City", null)
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Core_Ex1.Models.Flights", null)
                        .WithMany()
                        .HasForeignKey("FightsFightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_Core_Ex1.Models.FlightFacility", b =>
                {
                    b.HasOne("MVC_Core_Ex1.Models.Facility", "Facility")
                        .WithMany("FlightFacilities")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Core_Ex1.Models.Flights", "Flights")
                        .WithMany("FlightFacilities")
                        .HasForeignKey("FightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facility");

                    b.Navigation("Flights");
                });

            modelBuilder.Entity("MVC_Core_Ex1.Models.Facility", b =>
                {
                    b.Navigation("FlightFacilities");
                });

            modelBuilder.Entity("MVC_Core_Ex1.Models.Flights", b =>
                {
                    b.Navigation("FlightFacilities");
                });
#pragma warning restore 612, 618
        }
    }
}
