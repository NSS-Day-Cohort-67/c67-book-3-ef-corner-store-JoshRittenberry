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

// Post Endpoints

// Cashiers #1 - Add a Cashier
app.MapPost("/api/cashiers", (CornerStoreDbContext db, Cashier cashier) =>
{
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

// Put Endpoints

// Delete Endpoints

app.Run();

//don't move or change this!
public partial class Program { }