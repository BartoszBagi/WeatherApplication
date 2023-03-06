﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vetero.Persistance;

#nullable disable

namespace Vetero.Persistance.Migrations
{
    [DbContext(typeof(VeteroDbContext))]
    [Migration("20230306203435_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Vetero")
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Vetero.Domain.Entities.WeatherData.WeatherStationData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Temperature")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("WeatherStationData", "Vetero");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataDate = new DateTime(2023, 3, 6, 21, 34, 35, 396, DateTimeKind.Local).AddTicks(3928),
                            Temperature = 36.600000000000001
                        },
                        new
                        {
                            Id = 2,
                            DataDate = new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            Temperature = 38.600000000000001
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
