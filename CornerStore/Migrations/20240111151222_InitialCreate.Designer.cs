﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CornerStore.Migrations
{
    [DbContext(typeof(CornerStoreDbContext))]
    [Migration("20240111151222_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CornerStore.Models.Cashier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cashiers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Jane",
                            LastName = "Smith"
                        });
                });

            modelBuilder.Entity("CornerStore.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Beverages"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Snacks"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Fresh Produce"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Bakery"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Dairy"
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Frozen Foods"
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "Personal Care"
                        });
                });

            modelBuilder.Entity("CornerStore.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CashierId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("PaidOnDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CashierId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CashierId = 1,
                            PaidOnDate = new DateTime(2024, 1, 10, 6, 45, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CashierId = 1,
                            PaidOnDate = new DateTime(2024, 1, 10, 7, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CashierId = 1,
                            PaidOnDate = new DateTime(2024, 1, 10, 8, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CashierId = 1,
                            PaidOnDate = new DateTime(2024, 1, 10, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CashierId = 1,
                            PaidOnDate = new DateTime(2024, 1, 10, 9, 45, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CashierId = 1,
                            PaidOnDate = new DateTime(2024, 1, 10, 10, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CashierId = 1,
                            PaidOnDate = new DateTime(2024, 1, 10, 7, 45, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CashierId = 1,
                            PaidOnDate = new DateTime(2024, 1, 10, 8, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CashierId = 1,
                            PaidOnDate = new DateTime(2024, 1, 10, 9, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            CashierId = 1,
                            PaidOnDate = new DateTime(2024, 1, 10, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            CashierId = 1,
                            PaidOnDate = new DateTime(2024, 1, 10, 10, 45, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            CashierId = 2,
                            PaidOnDate = new DateTime(2024, 1, 10, 7, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            CashierId = 2,
                            PaidOnDate = new DateTime(2024, 1, 10, 8, 45, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            CashierId = 2,
                            PaidOnDate = new DateTime(2024, 1, 10, 9, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15,
                            CashierId = 2,
                            PaidOnDate = new DateTime(2024, 1, 10, 10, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 16,
                            CashierId = 2,
                            PaidOnDate = new DateTime(2024, 1, 10, 7, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 17,
                            CashierId = 2,
                            PaidOnDate = new DateTime(2024, 1, 10, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 18,
                            CashierId = 2,
                            PaidOnDate = new DateTime(2024, 1, 10, 9, 45, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 19,
                            CashierId = 2,
                            PaidOnDate = new DateTime(2024, 1, 10, 10, 30, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CornerStore.Models.OrderProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderId = 1,
                            ProductId = 5,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 2,
                            OrderId = 2,
                            ProductId = 1,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 3,
                            OrderId = 2,
                            ProductId = 2,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 4,
                            OrderId = 3,
                            ProductId = 3,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 5,
                            OrderId = 3,
                            ProductId = 4,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 6,
                            OrderId = 4,
                            ProductId = 5,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 7,
                            OrderId = 4,
                            ProductId = 6,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 8,
                            OrderId = 5,
                            ProductId = 7,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 9,
                            OrderId = 5,
                            ProductId = 8,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 10,
                            OrderId = 6,
                            ProductId = 9,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 11,
                            OrderId = 6,
                            ProductId = 10,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 12,
                            OrderId = 7,
                            ProductId = 11,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 13,
                            OrderId = 7,
                            ProductId = 12,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 14,
                            OrderId = 8,
                            ProductId = 13,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 15,
                            OrderId = 8,
                            ProductId = 14,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 16,
                            OrderId = 9,
                            ProductId = 15,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 17,
                            OrderId = 9,
                            ProductId = 16,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 18,
                            OrderId = 10,
                            ProductId = 17,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 19,
                            OrderId = 10,
                            ProductId = 18,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 20,
                            OrderId = 11,
                            ProductId = 19,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 21,
                            OrderId = 11,
                            ProductId = 20,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 22,
                            OrderId = 12,
                            ProductId = 21,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 23,
                            OrderId = 12,
                            ProductId = 22,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 24,
                            OrderId = 13,
                            ProductId = 23,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 25,
                            OrderId = 13,
                            ProductId = 24,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 26,
                            OrderId = 14,
                            ProductId = 25,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 27,
                            OrderId = 14,
                            ProductId = 26,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 28,
                            OrderId = 15,
                            ProductId = 27,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 29,
                            OrderId = 15,
                            ProductId = 28,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 30,
                            OrderId = 16,
                            ProductId = 29,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 31,
                            OrderId = 16,
                            ProductId = 30,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 32,
                            OrderId = 17,
                            ProductId = 1,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 33,
                            OrderId = 17,
                            ProductId = 2,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 34,
                            OrderId = 18,
                            ProductId = 3,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 35,
                            OrderId = 18,
                            ProductId = 4,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 36,
                            OrderId = 19,
                            ProductId = 5,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 37,
                            OrderId = 19,
                            ProductId = 6,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("CornerStore.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Coca-Cola",
                            CategoryId = 1,
                            Price = 1.00m,
                            ProductName = "Coca-Cola"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Lays",
                            CategoryId = 2,
                            Price = 2.50m,
                            ProductName = "Lays Chips"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "AquaFresh",
                            CategoryId = 4,
                            Price = 2.25m,
                            ProductName = "AquaFresh Water"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "BakersJoy",
                            CategoryId = 5,
                            Price = 3.0m,
                            ProductName = "Golden Wheat Bread"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "DairyBest",
                            CategoryId = 6,
                            Price = 3.75m,
                            ProductName = "FarmFresh Milk"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "FrostyDelight",
                            CategoryId = 7,
                            Price = 4.5m,
                            ProductName = "Arctic Ice Cream"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "HerbalEssence",
                            CategoryId = 1,
                            Price = 5.25m,
                            ProductName = "Lavender Shampoo"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "NatureCrunch",
                            CategoryId = 2,
                            Price = 6.0m,
                            ProductName = "Crunchy Granola Bars"
                        },
                        new
                        {
                            Id = 9,
                            Brand = "TropicalTaste",
                            CategoryId = 3,
                            Price = 6.75m,
                            ProductName = "Exotic Fruit Mix"
                        },
                        new
                        {
                            Id = 10,
                            Brand = "SweetTreats",
                            CategoryId = 4,
                            Price = 7.5m,
                            ProductName = "Honey Glazed Donuts"
                        },
                        new
                        {
                            Id = 11,
                            Brand = "CheeseHeaven",
                            CategoryId = 5,
                            Price = 8.25m,
                            ProductName = "Gourmet Cheese Spread"
                        },
                        new
                        {
                            Id = 12,
                            Brand = "GreenHarvest",
                            CategoryId = 6,
                            Price = 9.0m,
                            ProductName = "Frozen Veggie Mix"
                        },
                        new
                        {
                            Id = 13,
                            Brand = "EcoPure",
                            CategoryId = 7,
                            Price = 9.75m,
                            ProductName = "Organic Body Wash"
                        },
                        new
                        {
                            Id = 14,
                            Brand = "ZestyFizz",
                            CategoryId = 1,
                            Price = 10.5m,
                            ProductName = "Sparkling Lemonade"
                        },
                        new
                        {
                            Id = 15,
                            Brand = "CookieCraze",
                            CategoryId = 2,
                            Price = 11.25m,
                            ProductName = "Chocolate Chip Cookies"
                        },
                        new
                        {
                            Id = 16,
                            Brand = "NuttyBuddy",
                            CategoryId = 3,
                            Price = 12.0m,
                            ProductName = "Premium Nuts Mix"
                        },
                        new
                        {
                            Id = 17,
                            Brand = "HealthStart",
                            CategoryId = 4,
                            Price = 12.75m,
                            ProductName = "Multigrain Cereal"
                        },
                        new
                        {
                            Id = 18,
                            Brand = "YoguRich",
                            CategoryId = 5,
                            Price = 13.5m,
                            ProductName = "Greek Yogurt"
                        },
                        new
                        {
                            Id = 19,
                            Brand = "QuickSlice",
                            CategoryId = 6,
                            Price = 14.25m,
                            ProductName = "Pepperoni Pizza"
                        },
                        new
                        {
                            Id = 20,
                            Brand = "FreshGlow",
                            CategoryId = 7,
                            Price = 15.0m,
                            ProductName = "Cucumber Facewash"
                        },
                        new
                        {
                            Id = 21,
                            Brand = "SoothingSips",
                            CategoryId = 1,
                            Price = 15.75m,
                            ProductName = "Raspberry Tea"
                        },
                        new
                        {
                            Id = 22,
                            Brand = "PopSnack",
                            CategoryId = 2,
                            Price = 16.5m,
                            ProductName = "Caramel Popcorn"
                        },
                        new
                        {
                            Id = 23,
                            Brand = "IslandDrink",
                            CategoryId = 3,
                            Price = 17.25m,
                            ProductName = "Tropical Juice"
                        },
                        new
                        {
                            Id = 24,
                            Brand = "NutSpread",
                            CategoryId = 4,
                            Price = 18.0m,
                            ProductName = "Peanut Butter"
                        },
                        new
                        {
                            Id = 25,
                            Brand = "BakersDelight",
                            CategoryId = 5,
                            Price = 18.75m,
                            ProductName = "Strawberry CheeseCake"
                        },
                        new
                        {
                            Id = 26,
                            Brand = "AsianFlavors",
                            CategoryId = 6,
                            Price = 19.5m,
                            ProductName = "Vegetable Spring Rolls"
                        },
                        new
                        {
                            Id = 27,
                            Brand = "AromaWorld",
                            CategoryId = 7,
                            Price = 20.25m,
                            ProductName = "Vanilla Scented Candles"
                        },
                        new
                        {
                            Id = 28,
                            Brand = "NutriDairy",
                            CategoryId = 1,
                            Price = 21.0m,
                            ProductName = "Almond Milk"
                        },
                        new
                        {
                            Id = 29,
                            Brand = "HealthyCrunch",
                            CategoryId = 2,
                            Price = 21.75m,
                            ProductName = "Olive Oil Chips"
                        },
                        new
                        {
                            Id = 30,
                            Brand = "OrchardFresh",
                            CategoryId = 3,
                            Price = 22.5m,
                            ProductName = "Apple Cider"
                        });
                });

            modelBuilder.Entity("CornerStore.Models.Order", b =>
                {
                    b.HasOne("CornerStore.Models.Cashier", "Cashier")
                        .WithMany()
                        .HasForeignKey("CashierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cashier");
                });

            modelBuilder.Entity("CornerStore.Models.OrderProduct", b =>
                {
                    b.HasOne("CornerStore.Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CornerStore.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CornerStore.Models.Product", b =>
                {
                    b.HasOne("CornerStore.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CornerStore.Models.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
