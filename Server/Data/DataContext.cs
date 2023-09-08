using DoanTMDT.Shared;
using Microsoft.EntityFrameworkCore;

namespace DoanTMDT.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });

            modelBuilder.Entity<CartItem>()
               .HasKey(ci => new { ci.UserId, ci.ProductId, ci.EditionId });
            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.EditionId });

            modelBuilder.Entity<Edition>().HasData(
                    new Edition { Id = 1, Name = "Default" },
                    new Edition { Id = 2, Name = "Key-code" },
                    new Edition { Id = 3, Name = "Account" },
                    new Edition { Id = 4, Name = "Blu-ray" },
                    new Edition { Id = 5, Name = "PC" },
                    new Edition { Id = 6, Name = "PlayStation" },
                    new Edition { Id = 7, Name = "Nitendo" },
                    new Edition { Id = 8, Name = "Xbox" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Action-RPG",
                    Url = "action-rpg",
                },
                new Category
                {
                    Id = 2,
                    Name = "Open world",
                    Url = "open world",
                },
                new Category
                {
                    Id = 3,
                    Name = "FPS",
                    Url = "fps",
                },
                new Category
                {
                    Id = 4,
                    Name = "Souls-Like",
                    Url = "souls-like",
                }
                );

            modelBuilder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 1,
                    BrandName = "From Software",
                    BrandUrl = "from software",
                },
                new Brand
                {
                    Id = 2,
                    BrandName = "EA",
                    BrandUrl = "ea",
                },
                new Brand
                {
                    Id = 3,
                    BrandName = "Gearbox Software",
                    BrandUrl = "gearbox softwaree",
                },
                new Brand
                {
                    Id = 4,
                    BrandName = "Unknown Worlds Entertainment",
                    BrandUrl = "Unknown Worlds Entertainment",
                },
                new Brand
                {
                    Id = 5,
                    BrandName = "Hello Games",
                    BrandUrl = "hello games",
                },
                new Brand
                {
                    Id = 6,
                    BrandName = "Vale",
                    BrandUrl = "vale",
                }
                );


            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Borderlands 3",
                        Description = "The original shooter-looter returns, packing bazillions of guns and a mayhem-fueled adventure! Blast through new worlds and enemies as one of four new Vault Hunters.",
                        ImageUrl = "https://hadoantv.com/wp-content/uploads/2021/01/download-Borderlands-3-PHYSCHO-KREIG-AND-THE-FANTASTIC-FUSTERCLUCK-hadoan-tv-750x750.jpg",
                        CategoryId = 1,
                        BrandId = 3,

                    },
                    new Product
                    {
                        Id = 2,
                        Title = "ELDEN RING",
                        Description = "THE NEW FANTASY ACTION RPG. Rise, Tarnished, and be guided by grace to brandish the power of the Elden Ring and become an Elden Lord in the Lands Between. ",
                        ImageUrl = "https://assets-prd.ignimgs.com/2021/06/12/elden-ring-button-03-1623460560664.jpg",
                        CategoryId = 4,
                        BrandId = 1
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Titanfall® 2",
                        Description = "Respawn Entertainment gives you the most advanced titan technology in its new, single player campaign & multiplayer experience. Combine & conquer with new titans & pilots, deadlier weapons, & customization and progression systems that help you and your titan flow as one unstoppable killing force.",
                        ImageUrl = "https://img.wattpad.com/cover/253094870-256-k283076.jpg",
                        CategoryId = 3,
                        BrandId = 2,
                    },
                    new Product
                    {
                        Id = 4,
                        CategoryId = 2,
                        BrandId = 2,
                        Title = "Battlefield 1 ™",
                        Description = "Battlefield™ 1 takes you back to The Great War, WW1, where new technology and worldwide conflict changed the face of warfare forever.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/vi/f/fc/Battlefield_1_cover_art.jpg",
                    },
                    new Product
                    {
                        Id = 5,
                        CategoryId = 2,
                        Title = "Subnautica",
                        BrandId = 5,
                        Description = "Descend into the depths of an alien underwater world filled with wonder and peril. Craft equipment, pilot submarines and out-smart wildlife to explore lush coral reefs, volcanoes, cave systems, and more - all while trying to survive.",
                        ImageUrl = "https://gamek.mediacdn.vn/133514250583805952/2021/2/6/photo-1-1612629866025923303140.jpg",

                    },
                    new Product
                    {
                        Id = 6,
                        CategoryId = 2,
                        BrandId = 5,
                        Title = "No Man's Sky",
                        Description = "No Man's Sky is a game about exploration and survival in an infinite procedurally generated universe.",
                        ImageUrl = "https://gamein.wiki/wp-content/uploads/2020/11/No-Mans-Sky-Poster.jpg",

                    },
                    new Product
                    {
                        Id = 7,
                        CategoryId = 3,
                        BrandId = 6,
                        Title = "Half-Life 2",
                        Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",

                    },
                    new Product
                    {
                        Id = 8,
                        CategoryId = 3,
                        BrandId = 6,
                        Title = "Diablo II",
                        Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                    },
                    new Product
                    {
                        Id = 9,
                        CategoryId = 3,
                        BrandId = 5,
                        Title = "Day of the Tentacle",
                        Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",

                    }

                    );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 5,
                    Price = 13.9m,
                    OriginalPrice = 59.9m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 4,
                    Price = 47.9m,
                    OriginalPrice = 59.9m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 7,
                    Price = 10.9m,
                    OriginalPrice = 29.9m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 5,
                    Price = 7.99m,
                    OriginalPrice = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 2,
                    Price = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 5,
                    Price = 3.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 6,
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 7,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 5,
                    Price = 3.99m,
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 5,
                    Price = 2.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 3,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 8,
                    Price = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 7,
                    Price = 49.99m,
                    OriginalPrice = 59.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    EditionId = 1,
                    Price = 9.99m,
                    OriginalPrice = 24.99m,
                },
                new ProductVariant
                {
                    ProductId = 9,
                    EditionId = 7,
                    Price = 14.99m
                }

            );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

    }
}
