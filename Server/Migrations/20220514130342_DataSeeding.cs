using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoanTMDT.Server.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName", "BrandUrl", "Deleted", "Icon", "Visible" },
                values: new object[,]
                {
                    { 1, "From Software", "from software", false, "", true },
                    { 2, "EA", "ea", false, "", true },
                    { 3, "Gearbox Software", "gearbox softwaree", false, "", true },
                    { 4, "Unknown Worlds Entertainment", "Unknown Worlds Entertainment", false, "", true },
                    { 5, "Hello Games", "hello games", false, "", true },
                    { 6, "Vale", "vale", false, "", true }
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "Deleted", "Name", "Url", "Visible" },
                values: new object[,]
                {
                    { 4, false, "Souls-Like", "souls-like", true },
                    { 3, false, "FPS", "fps", true },
                    { 1, false, "Action-RPG", "action-rpg", true },
                    { 2, false, "Open world", "open world", true }
                });

            migrationBuilder.InsertData(
                table: "Editions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "Nitendo" },
                    { 1, "Default" },
                    { 2, "Key-code" },
                    { 3, "Account" },
                    { 4, "Blu-ray" },
                    { 5, "PC" },
                    { 6, "PlayStation" },
                    { 8, "Xbox" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "DateCreated", "Deleted", "Description", "ImageUrl", "Title", "Visible" },
                values: new object[,]
                {
                    { 1, 3, 1, new DateTime(2022, 5, 14, 20, 3, 41, 802, DateTimeKind.Local).AddTicks(5161), false, "The original shooter-looter returns, packing bazillions of guns and a mayhem-fueled adventure! Blast through new worlds and enemies as one of four new Vault Hunters.", "https://hadoantv.com/wp-content/uploads/2021/01/download-Borderlands-3-PHYSCHO-KREIG-AND-THE-FANTASTIC-FUSTERCLUCK-hadoan-tv-750x750.jpg", "Borderlands 3", true },
                    { 4, 2, 2, new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1782), false, "Battlefield™ 1 takes you back to The Great War, WW1, where new technology and worldwide conflict changed the face of warfare forever.", "https://upload.wikimedia.org/wikipedia/vi/f/fc/Battlefield_1_cover_art.jpg", "Battlefield 1 ™", true },
                    { 5, 5, 2, new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1785), false, "Descend into the depths of an alien underwater world filled with wonder and peril. Craft equipment, pilot submarines and out-smart wildlife to explore lush coral reefs, volcanoes, cave systems, and more - all while trying to survive.", "https://gamek.mediacdn.vn/133514250583805952/2021/2/6/photo-1-1612629866025923303140.jpg", "Subnautica", true },
                    { 6, 5, 2, new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1788), false, "No Man's Sky is a game about exploration and survival in an infinite procedurally generated universe.", "https://gamein.wiki/wp-content/uploads/2020/11/No-Mans-Sky-Poster.jpg", "No Man's Sky", true },
                    { 3, 2, 3, new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1778), false, "Respawn Entertainment gives you the most advanced titan technology in its new, single player campaign & multiplayer experience. Combine & conquer with new titans & pilots, deadlier weapons, & customization and progression systems that help you and your titan flow as one unstoppable killing force.", "https://img.wattpad.com/cover/253094870-256-k283076.jpg", "Titanfall® 2", true },
                    { 7, 6, 3, new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1791), false, "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2", true },
                    { 8, 6, 3, new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1794), false, "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II", true },
                    { 9, 5, 3, new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1797), false, "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle", true },
                    { 2, 1, 4, new DateTime(2022, 5, 14, 20, 3, 41, 804, DateTimeKind.Local).AddTicks(1745), false, "THE NEW FANTASY ACTION RPG. Rise, Tarnished, and be guided by grace to brandish the power of the Elden Ring and become an Elden Lord in the Lands Between. ", "https://assets-prd.ignimgs.com/2021/06/12/elden-ring-button-03-1623460560664.jpg", "ELDEN RING", true }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "EditionId", "ProductId", "Deleted", "OriginalPrice", "Price", "Visible" },
                values: new object[,]
                {
                    { 5, 1, false, 59.9m, 13.9m, true },
                    { 4, 1, false, 59.9m, 47.9m, true },
                    { 7, 1, false, 29.9m, 10.9m, true },
                    { 5, 4, false, 0m, 3.99m, true },
                    { 6, 4, false, 0m, 9.99m, true },
                    { 7, 4, false, 0m, 19.99m, true },
                    { 5, 5, false, 0m, 3.99m, true },
                    { 5, 6, false, 0m, 2.99m, true },
                    { 2, 3, false, 0m, 6.99m, true },
                    { 3, 7, false, 29.99m, 19.99m, true },
                    { 8, 7, false, 0m, 69.99m, true },
                    { 7, 7, false, 59.99m, 49.99m, true },
                    { 1, 8, false, 24.99m, 9.99m, true },
                    { 7, 9, false, 0m, 14.99m, true },
                    { 5, 2, false, 14.99m, 7.99m, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
