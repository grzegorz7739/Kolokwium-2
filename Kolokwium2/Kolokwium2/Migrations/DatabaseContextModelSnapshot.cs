﻿// <auto-generated />
using System;
using Kolokwium2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kolokwium2.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.5.24306.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Kolokwium2.Models.Backpacks", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("Backpacks");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            ItemId = 2,
                            Amount = 200
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Character_titles", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AcquierdAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CharacterId", "TitleId");

                    b.HasIndex("TitleId");

                    b.ToTable("character_titles");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            TitleId = 1,
                            AcquierdAt = new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Characters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentWeight")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MaxWeight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CurrentWeight = 20,
                            FirstName = "FirstName1",
                            LastName = "LastName1",
                            MaxWeight = 200
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Items", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "item1",
                            Weight = 20
                        },
                        new
                        {
                            Id = 2,
                            Name = "item2",
                            Weight = 30
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Titles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Titles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Title1"
                        });
                });

            modelBuilder.Entity("Kolokwium2.Models.Backpacks", b =>
                {
                    b.HasOne("Kolokwium2.Models.Characters", "Character")
                        .WithMany("Backpacks")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kolokwium2.Models.Items", "Item")
                        .WithMany("Backpacks")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Kolokwium2.Models.Character_titles", b =>
                {
                    b.HasOne("Kolokwium2.Models.Characters", "Character")
                        .WithMany("CharacterTitles")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kolokwium2.Models.Titles", "Title")
                        .WithMany("CharacterTitles")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Kolokwium2.Models.Characters", b =>
                {
                    b.Navigation("Backpacks");

                    b.Navigation("CharacterTitles");
                });

            modelBuilder.Entity("Kolokwium2.Models.Items", b =>
                {
                    b.Navigation("Backpacks");
                });

            modelBuilder.Entity("Kolokwium2.Models.Titles", b =>
                {
                    b.Navigation("CharacterTitles");
                });
#pragma warning restore 612, 618
        }
    }
}
