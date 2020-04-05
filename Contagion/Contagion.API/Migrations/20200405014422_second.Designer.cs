﻿// <auto-generated />
using System;
using Contagion.API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Contagion.API.Migrations
{
    [DbContext(typeof(ContagionDbContext))]
    [Migration("20200405014422_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Contagion.API.Models.User", b =>
                {
                    b.Property<int>("UserPhone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Lat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Long")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UserPhone1")
                        .HasColumnType("int");

                    b.HasKey("UserPhone");

                    b.HasIndex("UserPhone1");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserPhone = 1234567890,
                            Lat = -13.12m,
                            Long = 16.32m
                        },
                        new
                        {
                            UserPhone = 987653432,
                            Lat = 43.54m,
                            Long = -78.65m
                        });
                });

            modelBuilder.Entity("Contagion.API.Models.User", b =>
                {
                    b.HasOne("Contagion.API.Models.User", null)
                        .WithMany("users")
                        .HasForeignKey("UserPhone1");
                });
#pragma warning restore 612, 618
        }
    }
}
