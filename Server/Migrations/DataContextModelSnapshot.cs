﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NWSInventaire.Server.Data;

#nullable disable

namespace NWSInventaire.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NWSInventaire.Models.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("EndLend")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastReminder")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartLend")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("MaterialId");

                    b.HasIndex("StudentId");

                    b.ToTable("materials");
                });

            modelBuilder.Entity("NWSInventaire.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("StudentMail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("StudentId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("NWSInventaire.Models.Material", b =>
                {
                    b.HasOne("NWSInventaire.Models.Student", "student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("student");
                });
#pragma warning restore 612, 618
        }
    }
}
