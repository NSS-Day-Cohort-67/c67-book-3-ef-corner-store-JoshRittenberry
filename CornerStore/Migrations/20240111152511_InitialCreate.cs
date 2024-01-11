using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CornerStore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cashiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cashiers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CashierId = table.Column<int>(type: "integer", nullable: false),
                    PaidOnDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Cashiers_CashierId",
                        column: x => x.CashierId,
                        principalTable: "Cashiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductName = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cashiers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "John", "Doe" },
                    { 2, "Jane", "Smith" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Beverages" },
                    { 2, "Snacks" },
                    { 3, "Fresh Produce" },
                    { 4, "Bakery" },
                    { 5, "Dairy" },
                    { 6, "Frozen Foods" },
                    { 7, "Personal Care" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CashierId", "PaidOnDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 10, 6, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2024, 1, 10, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2024, 1, 10, 8, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2024, 1, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, new DateTime(2024, 1, 10, 9, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2024, 1, 10, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2024, 1, 10, 7, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(2024, 1, 10, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(2024, 1, 10, 9, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2024, 1, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, new DateTime(2024, 1, 10, 10, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 2, new DateTime(2024, 1, 10, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 2, new DateTime(2024, 1, 10, 8, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 2, new DateTime(2024, 1, 10, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 2, new DateTime(2024, 1, 10, 10, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 2, new DateTime(2024, 1, 10, 7, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 2, new DateTime(2024, 1, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 2, new DateTime(2024, 1, 10, 9, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 2, new DateTime(2024, 1, 10, 10, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, "Coca-Cola", 1, 1.00m, "Coca-Cola" },
                    { 2, "Lays", 2, 2.50m, "Lays Chips" },
                    { 3, "AquaFresh", 4, 2.25m, "AquaFresh Water" },
                    { 4, "BakersJoy", 5, 3.0m, "Golden Wheat Bread" },
                    { 5, "DairyBest", 6, 3.75m, "FarmFresh Milk" },
                    { 6, "FrostyDelight", 7, 4.5m, "Arctic Ice Cream" },
                    { 7, "HerbalEssence", 1, 5.25m, "Lavender Shampoo" },
                    { 8, "NatureCrunch", 2, 6.0m, "Crunchy Granola Bars" },
                    { 9, "TropicalTaste", 3, 6.75m, "Exotic Fruit Mix" },
                    { 10, "SweetTreats", 4, 7.5m, "Honey Glazed Donuts" },
                    { 11, "CheeseHeaven", 5, 8.25m, "Gourmet Cheese Spread" },
                    { 12, "GreenHarvest", 6, 9.0m, "Frozen Veggie Mix" },
                    { 13, "EcoPure", 7, 9.75m, "Organic Body Wash" },
                    { 14, "ZestyFizz", 1, 10.5m, "Sparkling Lemonade" },
                    { 15, "CookieCraze", 2, 11.25m, "Chocolate Chip Cookies" },
                    { 16, "NuttyBuddy", 3, 12.0m, "Premium Nuts Mix" },
                    { 17, "HealthStart", 4, 12.75m, "Multigrain Cereal" },
                    { 18, "YoguRich", 5, 13.5m, "Greek Yogurt" },
                    { 19, "QuickSlice", 6, 14.25m, "Pepperoni Pizza" },
                    { 20, "FreshGlow", 7, 15.0m, "Cucumber Facewash" },
                    { 21, "SoothingSips", 1, 15.75m, "Raspberry Tea" },
                    { 22, "PopSnack", 2, 16.5m, "Caramel Popcorn" },
                    { 23, "IslandDrink", 3, 17.25m, "Tropical Juice" },
                    { 24, "NutSpread", 4, 18.0m, "Peanut Butter" },
                    { 25, "BakersDelight", 5, 18.75m, "Strawberry CheeseCake" },
                    { 26, "AsianFlavors", 6, 19.5m, "Vegetable Spring Rolls" },
                    { 27, "AromaWorld", 7, 20.25m, "Vanilla Scented Candles" },
                    { 28, "NutriDairy", 1, 21.0m, "Almond Milk" },
                    { 29, "HealthyCrunch", 2, 21.75m, "Olive Oil Chips" },
                    { 30, "OrchardFresh", 3, 22.5m, "Apple Cider" }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 5, 2 },
                    { 2, 2, 1, 2 },
                    { 3, 2, 2, 3 },
                    { 4, 3, 3, 1 },
                    { 5, 3, 4, 2 },
                    { 6, 4, 5, 2 },
                    { 7, 4, 6, 1 },
                    { 8, 5, 7, 3 },
                    { 9, 5, 8, 2 },
                    { 10, 6, 9, 1 },
                    { 11, 6, 10, 2 },
                    { 12, 7, 11, 2 },
                    { 13, 7, 12, 1 },
                    { 14, 8, 13, 3 },
                    { 15, 8, 14, 2 },
                    { 16, 9, 15, 1 },
                    { 17, 9, 16, 2 },
                    { 18, 10, 17, 2 },
                    { 19, 10, 18, 1 },
                    { 20, 11, 19, 3 },
                    { 21, 11, 20, 2 },
                    { 22, 12, 21, 1 },
                    { 23, 12, 22, 2 },
                    { 24, 13, 23, 2 },
                    { 25, 13, 24, 1 },
                    { 26, 14, 25, 3 },
                    { 27, 14, 26, 2 },
                    { 28, 15, 27, 1 },
                    { 29, 15, 28, 2 },
                    { 30, 16, 29, 2 },
                    { 31, 16, 30, 1 },
                    { 32, 17, 1, 3 },
                    { 33, 17, 2, 2 },
                    { 34, 18, 3, 1 },
                    { 35, 18, 4, 2 },
                    { 36, 19, 5, 2 },
                    { 37, 19, 6, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderId",
                table: "OrderProducts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CashierId",
                table: "Orders",
                column: "CashierId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Cashiers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
