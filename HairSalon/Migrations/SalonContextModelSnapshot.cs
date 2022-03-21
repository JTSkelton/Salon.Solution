﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Salon.Models;

namespace Salon.Migrations
{
    [DbContext(typeof(SalonContext))]
    partial class SalonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Salon.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("StylistId")
                        .HasColumnType("int");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Salon.Models.Stylist", b =>
                {
                    b.Property<int>("StylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("HairStyles")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("StylistName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("StylistId");

                    b.ToTable("Stylists");
                });

            modelBuilder.Entity("Salon.Models.StylistClients", b =>
                {
                    b.Property<int>("StylistClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("StylistId")
                        .HasColumnType("int");

                    b.Property<string>("StylistName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("StylistClientId");

                    b.HasIndex("ClientId");

                    b.HasIndex("StylistId");

                    b.ToTable("StylistClients");
                });

            modelBuilder.Entity("Salon.Models.StylistClients", b =>
                {
                    b.HasOne("Salon.Models.Client", "Clients")
                        .WithMany("JoinEntities")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Salon.Models.Stylist", "Stylists")
                        .WithMany("JoinEntities")
                        .HasForeignKey("StylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clients");

                    b.Navigation("Stylists");
                });

            modelBuilder.Entity("Salon.Models.Client", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("Salon.Models.Stylist", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
