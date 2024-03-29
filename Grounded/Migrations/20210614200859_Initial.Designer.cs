﻿// <auto-generated />
using Grounded.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Grounded.Migrations
{
    [DbContext(typeof(GroundedContext))]
    [Migration("20210614200859_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Grounded.Models.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ResourceAdvice")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ResourceColor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ResourceExercise")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ResourceImage")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ResourceLink")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ResourceMeditation")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ResourceMusic")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ResourceQuote")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ResourceId");

                    b.ToTable("Resources");
                });
#pragma warning restore 612, 618
        }
    }
}
