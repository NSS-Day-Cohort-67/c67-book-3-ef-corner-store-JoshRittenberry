using Microsoft.EntityFrameworkCore;
using CornerStore.Models;
public class CornerStoreDbContext : DbContext
{
    public DbSet<Cashier> Cashiers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }
    public DbSet<Product> Products { get; set; }

    public CornerStoreDbContext(DbContextOptions<CornerStoreDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed data for Category
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, CategoryName = "Beverages" },
            new Category { Id = 2, CategoryName = "Snacks" },
            new Category { Id = 3, CategoryName = "Fresh Produce" },
            new Category { Id = 4, CategoryName = "Bakery" },
            new Category { Id = 5, CategoryName = "Dairy" },
            new Category { Id = 6, CategoryName = "Frozen Foods" },
            new Category { Id = 7, CategoryName = "Personal Care" }
        );

        // Seed data for Product
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, ProductName = "Coca-Cola", Price = 1.00m, Brand = "Coca-Cola", CategoryId = 1 },
            new Product { Id = 2, ProductName = "Lays Chips", Price = 2.50m, Brand = "Lays", CategoryId = 2 },
            new Product { Id = 3, ProductName = "AquaFresh Water", Price = 2.25m, Brand = "AquaFresh", CategoryId = 4 },
            new Product { Id = 4, ProductName = "Golden Wheat Bread", Price = 3.0m, Brand = "BakersJoy", CategoryId = 5 },
            new Product { Id = 5, ProductName = "FarmFresh Milk", Price = 3.75m, Brand = "DairyBest", CategoryId = 6 },
            new Product { Id = 6, ProductName = "Arctic Ice Cream", Price = 4.5m, Brand = "FrostyDelight", CategoryId = 7 },
            new Product { Id = 7, ProductName = "Lavender Shampoo", Price = 5.25m, Brand = "HerbalEssence", CategoryId = 1 },
            new Product { Id = 8, ProductName = "Crunchy Granola Bars", Price = 6.0m, Brand = "NatureCrunch", CategoryId = 2 },
            new Product { Id = 9, ProductName = "Exotic Fruit Mix", Price = 6.75m, Brand = "TropicalTaste", CategoryId = 3 },
            new Product { Id = 10, ProductName = "Honey Glazed Donuts", Price = 7.5m, Brand = "SweetTreats", CategoryId = 4 },
            new Product { Id = 11, ProductName = "Gourmet Cheese Spread", Price = 8.25m, Brand = "CheeseHeaven", CategoryId = 5 },
            new Product { Id = 12, ProductName = "Frozen Veggie Mix", Price = 9.0m, Brand = "GreenHarvest", CategoryId = 6 },
            new Product { Id = 13, ProductName = "Organic Body Wash", Price = 9.75m, Brand = "EcoPure", CategoryId = 7 },
            new Product { Id = 14, ProductName = "Sparkling Lemonade", Price = 10.5m, Brand = "ZestyFizz", CategoryId = 1 },
            new Product { Id = 15, ProductName = "Chocolate Chip Cookies", Price = 11.25m, Brand = "CookieCraze", CategoryId = 2 },
            new Product { Id = 16, ProductName = "Premium Nuts Mix", Price = 12.0m, Brand = "NuttyBuddy", CategoryId = 3 },
            new Product { Id = 17, ProductName = "Multigrain Cereal", Price = 12.75m, Brand = "HealthStart", CategoryId = 4 },
            new Product { Id = 18, ProductName = "Greek Yogurt", Price = 13.5m, Brand = "YoguRich", CategoryId = 5 },
            new Product { Id = 19, ProductName = "Pepperoni Pizza", Price = 14.25m, Brand = "QuickSlice", CategoryId = 6 },
            new Product { Id = 20, ProductName = "Cucumber Facewash", Price = 15.0m, Brand = "FreshGlow", CategoryId = 7 },
            new Product { Id = 21, ProductName = "Raspberry Tea", Price = 15.75m, Brand = "SoothingSips", CategoryId = 1 },
            new Product { Id = 22, ProductName = "Caramel Popcorn", Price = 16.5m, Brand = "PopSnack", CategoryId = 2 },
            new Product { Id = 23, ProductName = "Tropical Juice", Price = 17.25m, Brand = "IslandDrink", CategoryId = 3 },
            new Product { Id = 24, ProductName = "Peanut Butter", Price = 18.0m, Brand = "NutSpread", CategoryId = 4 },
            new Product { Id = 25, ProductName = "Strawberry CheeseCake", Price = 18.75m, Brand = "BakersDelight", CategoryId = 5 },
            new Product { Id = 26, ProductName = "Vegetable Spring Rolls", Price = 19.5m, Brand = "AsianFlavors", CategoryId = 6 },
            new Product { Id = 27, ProductName = "Vanilla Scented Candles", Price = 20.25m, Brand = "AromaWorld", CategoryId = 7 },
            new Product { Id = 28, ProductName = "Almond Milk", Price = 21.0m, Brand = "NutriDairy", CategoryId = 1 },
            new Product { Id = 29, ProductName = "Olive Oil Chips", Price = 21.75m, Brand = "HealthyCrunch", CategoryId = 2 },
            new Product { Id = 30, ProductName = "Apple Cider", Price = 22.5m, Brand = "OrchardFresh", CategoryId = 3 }
        );

        // Seed data for Cashier
        modelBuilder.Entity<Cashier>().HasData(
            new Cashier { Id = 1, FirstName = "John", LastName = "Doe" },
            new Cashier { Id = 2, FirstName = "Jane", LastName = "Smith" }
        );

        // Seed data for Order
        modelBuilder.Entity<Order>().HasData(
            new Order {Id = 1, CashierId = 1, PaidOnDate = new DateTime(2024, 01, 10, 06, 45, 0) },
            new Order { Id = 2, CashierId = 1, PaidOnDate = new DateTime(2024, 01, 10, 07, 30, 0) },
            new Order { Id = 3, CashierId = 1, PaidOnDate = new DateTime(2024, 01, 10, 08, 15, 0) },
            new Order { Id = 4, CashierId = 1, PaidOnDate = new DateTime(2024, 01, 10, 09, 0, 0) },
            new Order { Id = 5, CashierId = 1, PaidOnDate = new DateTime(2024, 01, 10, 09, 45, 0) },
            new Order { Id = 6, CashierId = 1, PaidOnDate = new DateTime(2024, 01, 10, 10, 30, 0) },
            new Order { Id = 7, CashierId = 1, PaidOnDate = new DateTime(2024, 01, 10, 07, 45, 0) },
            new Order { Id = 8, CashierId = 1, PaidOnDate = new DateTime(2024, 01, 10, 08, 30, 0) },
            new Order { Id = 9, CashierId = 1, PaidOnDate = new DateTime(2024, 01, 10, 09, 15, 0) },
            new Order { Id = 10, CashierId = 1, PaidOnDate = new DateTime(2024, 01, 10, 10, 0, 0) },
            new Order { Id = 11, CashierId = 1, PaidOnDate = new DateTime(2024, 01, 10, 10, 45, 0) },
            new Order { Id = 12, CashierId = 2, PaidOnDate = new DateTime(2024, 01, 10, 07, 0, 0) },
            new Order { Id = 13, CashierId = 2, PaidOnDate = new DateTime(2024, 01, 10, 08, 45, 0) },
            new Order { Id = 14, CashierId = 2, PaidOnDate = new DateTime(2024, 01, 10, 09, 30, 0) },
            new Order { Id = 15, CashierId = 2, PaidOnDate = new DateTime(2024, 01, 10, 10, 15, 0) },
            new Order { Id = 16, CashierId = 2, PaidOnDate = new DateTime(2024, 01, 10, 07, 15, 0) },
            new Order { Id = 17, CashierId = 2, PaidOnDate = new DateTime(2024, 01, 10, 08, 0, 0) },
            new Order { Id = 18, CashierId = 2, PaidOnDate = new DateTime(2024, 01, 10, 09, 45, 0) },
            new Order { Id = 19, CashierId = 2, PaidOnDate = new DateTime(2024, 01, 10, 10, 30, 0) }
        );

        // Seed data for OrderProduct
        modelBuilder.Entity<OrderProduct>().HasData(
            new OrderProduct { Id = 1, ProductId = 5, OrderId = 1, Quantity = 2 },
            new OrderProduct { Id = 2, ProductId = 1, OrderId = 2, Quantity = 2 },
            new OrderProduct { Id = 3, ProductId = 2, OrderId = 2, Quantity = 3 },
            new OrderProduct { Id = 4, ProductId = 3, OrderId = 3, Quantity = 1 },
            new OrderProduct { Id = 5, ProductId = 4, OrderId = 3, Quantity = 2 },
            new OrderProduct { Id = 6, ProductId = 5, OrderId = 4, Quantity = 2 },
            new OrderProduct { Id = 7, ProductId = 6, OrderId = 4, Quantity = 1 },
            new OrderProduct { Id = 8, ProductId = 7, OrderId = 5, Quantity = 3 },
            new OrderProduct { Id = 9, ProductId = 8, OrderId = 5, Quantity = 2 },
            new OrderProduct { Id = 10, ProductId = 9, OrderId = 6, Quantity = 1 },
            new OrderProduct { Id = 11, ProductId = 10, OrderId = 6, Quantity = 2 },
            new OrderProduct { Id = 12, ProductId = 11, OrderId = 7, Quantity = 2 },
            new OrderProduct { Id = 13, ProductId = 12, OrderId = 7, Quantity = 1 },
            new OrderProduct { Id = 14, ProductId = 13, OrderId = 8, Quantity = 3 },
            new OrderProduct { Id = 15, ProductId = 14, OrderId = 8, Quantity = 2 },
            new OrderProduct { Id = 16, ProductId = 15, OrderId = 9, Quantity = 1 },
            new OrderProduct { Id = 17, ProductId = 16, OrderId = 9, Quantity = 2 },
            new OrderProduct { Id = 18, ProductId = 17, OrderId = 10, Quantity = 2 },
            new OrderProduct { Id = 19, ProductId = 18, OrderId = 10, Quantity = 1 },
            new OrderProduct { Id = 20, ProductId = 19, OrderId = 11, Quantity = 3 },
            new OrderProduct { Id = 21, ProductId = 20, OrderId = 11, Quantity = 2 },
            new OrderProduct { Id = 22, ProductId = 21, OrderId = 12, Quantity = 1 },
            new OrderProduct { Id = 23, ProductId = 22, OrderId = 12, Quantity = 2 },
            new OrderProduct { Id = 24, ProductId = 23, OrderId = 13, Quantity = 2 },
            new OrderProduct { Id = 25, ProductId = 24, OrderId = 13, Quantity = 1 },
            new OrderProduct { Id = 26, ProductId = 25, OrderId = 14, Quantity = 3 },
            new OrderProduct { Id = 27, ProductId = 26, OrderId = 14, Quantity = 2 },
            new OrderProduct { Id = 28, ProductId = 27, OrderId = 15, Quantity = 1 },
            new OrderProduct { Id = 29, ProductId = 28, OrderId = 15, Quantity = 2 },
            new OrderProduct { Id = 30, ProductId = 29, OrderId = 16, Quantity = 2 },
            new OrderProduct { Id = 31, ProductId = 30, OrderId = 16, Quantity = 1 },
            new OrderProduct { Id = 32, ProductId = 1, OrderId = 17, Quantity = 3 },
            new OrderProduct { Id = 33, ProductId = 2, OrderId = 17, Quantity = 2 },
            new OrderProduct { Id = 34, ProductId = 3, OrderId = 18, Quantity = 1 },
            new OrderProduct { Id = 35, ProductId = 4, OrderId = 18, Quantity = 2 },
            new OrderProduct { Id = 36, ProductId = 5, OrderId = 19, Quantity = 2 },
            new OrderProduct { Id = 37, ProductId = 6, OrderId = 19, Quantity = 1 }
        );
    }
}