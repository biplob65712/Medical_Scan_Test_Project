﻿// <auto-generated />
using System;
using MedicalScan.DATABASE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedicalScan.DATABASE.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240118134828_R1")]
    partial class R1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MedicalScan.MODELS.EntityModels.Doctor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SpecialtyID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SpecialtyID");

                    b.ToTable("DoctorTB");
                });

            modelBuilder.Entity("MedicalScan.MODELS.EntityModels.Specialty", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("SpecialtyTB");
                });

            modelBuilder.Entity("MedicalScan.MODELS.EntityModels.Doctor", b =>
                {
                    b.HasOne("MedicalScan.MODELS.EntityModels.Specialty", "Specialty")
                        .WithMany()
                        .HasForeignKey("SpecialtyID");

                    b.Navigation("Specialty");
                });
#pragma warning restore 612, 618
        }
    }
}