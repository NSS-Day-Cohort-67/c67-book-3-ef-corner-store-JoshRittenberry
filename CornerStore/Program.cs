using CornerStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core and provides dummy value for testing
builder.Services.AddNpgsql<CornerStoreDbContext>(builder.Configuration["CornerStoreDbConnectionString"] ?? "testing");

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Get Endpoints

// Cashiers #2 - Get a Cashier
app.MapGet("/api/cashiers/{id}", (CornerStoreDbContext db, int id) =>
{
    // https://localhost:7065/api/cashiers/2

    var cashier = db.Cashiers
        .Include(c => c.Orders)
            .ThenInclude(o => o.OrderProducts)
                .ThenInclude(op => op.Product)
                    .ThenInclude(p => p.Category)
        .SingleOrDefault(c => c.Id == id);

    return Results.Ok(new CashierDTO
    {
        Id = cashier.Id,
        FirstName = cashier.FirstName,
        LastName = cashier.LastName,
        Orders = cashier.Orders.Select(o => new OrderDTO
        {
            Id = o.Id,
            CashierId = o.CashierId,
            Cashier = null,
            PaidOnDate = o.PaidOnDate,
            OrderProducts = o.OrderProducts.Select(op => new OrderProductDTO
            {
                Id = op.Id,
                ProductId = op.ProductId,
                Product = new ProductDTO
                {
                    Id = op.Product.Id,
                    ProductName = op.Product.ProductName,
                    Price = op.Product.Price,
                    Brand = op.Product.Brand,
                    CategoryId = op.Product.CategoryId,
                    Category = new CategoryDTO
                    {
                        Id = op.Product.Category.Id,
                        CategoryName = op.Product.Category.CategoryName
                    }
                },
                OrderId = op.OrderId,
                Order = null,
                Quantity = op.Quantity
            }).ToList()
        }).ToList(),
    });
});

// Products #1 - Get all products with categories
app.MapGet("/api/products", (CornerStoreDbContext db, string? search) =>
{
    // https://localhost:7065/api/products
    // https://localhost:7065/api/products/?search=snacks
    try
    {
        var searchTerm = search?.ToLower(); // Convert searchTerm to lowercase

        var productsQuery = db.Products
            .Include(p => p.Category)
            .AsQueryable(); // Start with all products

        if (!String.IsNullOrWhiteSpace(searchTerm))
        {
            productsQuery = productsQuery
                .Where(p =>
                    p.ProductName.ToLower().Contains(searchTerm) ||
                    p.Category.CategoryName.ToLower().Contains(searchTerm)
                );
        }

        var products = productsQuery
            .OrderBy(p => p.Id)
            .Select(p => new ProductDTO
            {
                Id = p.Id,
                ProductName = p.ProductName,
                Price = p.Price,
                Brand = p.Brand,
                CategoryId = p.CategoryId,
                Category = new CategoryDTO
                {
                    Id = p.Category.Id,
                    CategoryName = p.Category.CategoryName
                }
            })
            .ToList();

        return Results.Ok(products); // Return the list of products with 200 OK
    }
    catch
    {
        return Results.NotFound();
    }
});

// Post Endpoints

// Cashiers #1 - Add a Cashier
app.MapPost("/api/cashiers", (CornerStoreDbContext db, Cashier cashier) =>
{
    // https://localhost:7065/api/cashiers/
    // {
    //     "firstName": "Haley",
    //     "lastName": "Rittenberry"
    // }

    try
    {
        db.Cashiers.Add(cashier);
        db.SaveChanges();

        var newCashier = db.Cashiers
            .FirstOrDefault(c => c.Id == cashier.Id);

        if (newCashier == null)
        {
            return Results.NotFound();
        }

        return Results.Ok(cashier.Id);
    }
    catch (DbUpdateException)
    {
        return Results.BadRequest("Invalid data submitted");
    }
});

// Products #2 - Add a Product
app.MapPost("/api/products", (CornerStoreDbContext db, Product product) =>
{
    // https://localhost:7065/api/products/
    // {
    //     "productName": "Dove Men's + Care",
    //     "price": 9.99,
    //     "brand": "Dove",
    //     "categoryId": 7
    // }

    try
    {
        db.Products.Add(product);
        db.SaveChanges();

        var newProduct = db.Products
            .Include(p => p.Category)
            .FirstOrDefault(p => p.Id == product.Id);

        if (newProduct == null)
        {
            return Results.NotFound();
        }

        return Results.Ok(new ProductDTO
        {
            Id = newProduct.Id,
            ProductName = newProduct.ProductName,
            Price = newProduct.Price,
            Brand = newProduct.Brand,
            CategoryId = newProduct.CategoryId,
            Category = new CategoryDTO
            {
                Id = newProduct.Category.Id,
                CategoryName = newProduct.Category.CategoryName
            }
        });
    }
    catch (DbUpdateException)
    {
        return Results.BadRequest("Invalid data submitted");
    }
});

// Put Endpoints

// Delete Endpoints

app.Run();

//don't move or change this!
public partial class Program { }