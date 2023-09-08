﻿// <auto-generated />
using System;
using DoanTMDT.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoanTMDT.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220514130342_DataSeeding")]
    partial class DataSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoanTMDT.Shared.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrandUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandName = "From Software",
                            BrandUrl = "from software",
                            Deleted = false,
                            Icon = "",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            BrandName = "EA",
                            BrandUrl = "ea",
                            Deleted = false,
                            Icon = "",
                            Visible = true
                        },
                        new
                        {
                            Id = 3,
                            BrandName = "Gearbox Software",
                            BrandUrl = "gearbox softwaree",
                            Deleted = false,
                            Icon = "",
                            Visible = true
                        },
                        new
                        {
                            Id = 4,
                            BrandName = "Unknown Worlds Entertainment",
                            BrandUrl = "Unknown Worlds Entertainment",
                            Deleted = false,
                            Icon = "",
                            Visible = true
                        },
                        new
                        {
                            Id = 5,
                            BrandName = "Hello Games",
                            BrandUrl = "hello games",
                            Deleted = false,
                            Icon = "",
                            Visible = true
                        },
                        new
                        {
                            Id = 6,
                            BrandName = "Vale",
                            BrandUrl = "vale",
                            Deleted = false,
                            Icon = "",
                            Visible = true
                        });
                });

            modelBuilder.Entity("DoanTMDT.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            Name = "Action-RPG",
                            Url = "action-rpg",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            Name = "Open world",
                            Url = "open world",
                            Visible = true
                        },
                        new
                        {
                            Id = 3,
                            Deleted = false,
                            Name = "FPS",
                            Url = "fps",
                            Visible = true
                        },
                        new
                        {
                            Id = 4,
                            Deleted = false,
                            Name = "Souls-Like",
                            Url = "souls-like",
                            Visible = true
                        });
                });

            modelBuilder.Entity("DoanTMDT.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Key-code"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Account"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Blu-ray"
                        },
                        new
                        {
                            Id = 5,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 6,
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Nitendo"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Xbox"
                        });
                });

            modelBuilder.Entity("DoanTMDT.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 3,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 5, 14, 20, 3, 41, 802, DateTimeKind.Local).AddTicks(5161),
                            Deleted = false,
                            Description = "The original shooter-looter returns, packing bazillions of guns and a mayhem-fueled adventure! Blast through new worlds and enemies as one of four new Vault Hunters.",
                            ImageUrl = "https://hadoantv.com/wp-content/uploads/2021/01/download-Borderlands-3-PHYSCHO-KREIG-AND-THE-FANTASTIC-FUSTERCLUCK-hadoan-tv-750x750.jpg",
                            Title = "Borderlands 3",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 1,
                            CategoryId = 4,
                            DateCreated = new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1745),
                            Deleted = false,
                            Description = "THE NEW FANTASY ACTION RPG. Rise, Tarnished, and be guided by grace to brandish the power of the Elden Ring and become an Elden Lord in the Lands Between. ",
                            ImageUrl = "https://assets-prd.ignimgs.com/2021/06/12/elden-ring-button-03-1623460560664.jpg",
                            Title = "ELDEN RING",
                            Visible = true
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 2,
                            CategoryId = 3,
                            DateCreated = new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1778),
                            Deleted = false,
                            Description = "Respawn Entertainment gives you the most advanced titan technology in its new, single player campaign & multiplayer experience. Combine & conquer with new titans & pilots, deadlier weapons, & customization and progression systems that help you and your titan flow as one unstoppable killing force.",
                            ImageUrl = "https://img.wattpad.com/cover/253094870-256-k283076.jpg",
                            Title = "Titanfall® 2",
                            Visible = true
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 2,
                            CategoryId = 2,
                            DateCreated = new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1782),
                            Deleted = false,
                            Description = "Battlefield™ 1 takes you back to The Great War, WW1, where new technology and worldwide conflict changed the face of warfare forever.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/f/fc/Battlefield_1_cover_art.jpg",
                            Title = "Battlefield 1 ™",
                            Visible = true
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 5,
                            CategoryId = 2,
                            DateCreated = new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1785),
                            Deleted = false,
                            Description = "Descend into the depths of an alien underwater world filled with wonder and peril. Craft equipment, pilot submarines and out-smart wildlife to explore lush coral reefs, volcanoes, cave systems, and more - all while trying to survive.",
                            ImageUrl = "https://gamek.mediacdn.vn/133514250583805952/2021/2/6/photo-1-1612629866025923303140.jpg",
                            Title = "Subnautica",
                            Visible = true
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 5,
                            CategoryId = 2,
                            DateCreated = new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1788),
                            Deleted = false,
                            Description = "No Man's Sky is a game about exploration and survival in an infinite procedurally generated universe.",
                            ImageUrl = "https://gamein.wiki/wp-content/uploads/2020/11/No-Mans-Sky-Poster.jpg",
                            Title = "No Man's Sky",
                            Visible = true
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 6,
                            CategoryId = 3,
                            DateCreated = new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1791),
                            Deleted = false,
                            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                            Title = "Half-Life 2",
                            Visible = true
                        },
                        new
                        {
                            Id = 8,
                            BrandId = 6,
                            CategoryId = 3,
                            DateCreated = new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1794),
                            Deleted = false,
                            Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                            Title = "Diablo II",
                            Visible = true
                        },
                        new
                        {
                            Id = 9,
                            BrandId = 5,
                            CategoryId = 3,
                            DateCreated = new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1797),
                            Deleted = false,
                            Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                            Title = "Day of the Tentacle",
                            Visible = true
                        });
                });

            modelBuilder.Entity("DoanTMDT.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("EditionId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("ProductId", "EditionId");

                    b.HasIndex("EditionId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            EditionId = 5,
                            Deleted = false,
                            OriginalPrice = 59.9m,
                            Price = 13.9m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 4,
                            Deleted = false,
                            OriginalPrice = 59.9m,
                            Price = 47.9m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 7,
                            Deleted = false,
                            OriginalPrice = 29.9m,
                            Price = 10.9m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 5,
                            Deleted = false,
                            OriginalPrice = 14.99m,
                            Price = 7.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 3,
                            EditionId = 2,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 6.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 4,
                            EditionId = 5,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 3.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 4,
                            EditionId = 6,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 9.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 4,
                            EditionId = 7,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 19.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 5,
                            EditionId = 5,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 3.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 6,
                            EditionId = 5,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 2.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 3,
                            Deleted = false,
                            OriginalPrice = 29.99m,
                            Price = 19.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 8,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 69.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 7,
                            Deleted = false,
                            OriginalPrice = 59.99m,
                            Price = 49.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 8,
                            EditionId = 1,
                            Deleted = false,
                            OriginalPrice = 24.99m,
                            Price = 9.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 9,
                            EditionId = 7,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 14.99m,
                            Visible = true
                        });
                });

            modelBuilder.Entity("DoanTMDT.Shared.Product", b =>
                {
                    b.HasOne("DoanTMDT.Shared.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoanTMDT.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DoanTMDT.Shared.ProductVariant", b =>
                {
                    b.HasOne("DoanTMDT.Shared.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoanTMDT.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Edition");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DoanTMDT.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
