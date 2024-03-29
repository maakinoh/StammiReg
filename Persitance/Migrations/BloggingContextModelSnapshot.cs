﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persitance.StammiReg.Persitance.Entities;

#nullable disable

namespace Persitance.Migrations
{
    [DbContext(typeof(CTX.BloggingContext))]
    partial class BloggingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Persitance.StammiReg.Persitance.Entities.Meet", b =>
                {
                    b.Property<int>("MeetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MeetName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MeetID");

                    b.ToTable("Meets");
                });

            modelBuilder.Entity("Persitance.StammiReg.Persitance.Entities.Reg", b =>
                {
                    b.Property<int>("RegID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MeetID")
                        .HasColumnType("int");

                    b.HasKey("RegID");

                    b.HasIndex("MeetID");

                    b.ToTable("Regs");
                });

            modelBuilder.Entity("Persitance.StammiReg.Persitance.Entities.Reg", b =>
                {
                    b.HasOne("Persitance.StammiReg.Persitance.Entities.Meet", "Meet")
                        .WithMany()
                        .HasForeignKey("MeetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meet");
                });
#pragma warning restore 612, 618
        }
    }
}
