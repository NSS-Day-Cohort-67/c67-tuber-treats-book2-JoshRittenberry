using TuberTreats.Models;

List<Customer> customers = new List<Customer>()
{
    new Customer { Id = 1, Name = "Ava Martinez", Address = "962 Birch Boulevard, New York, CA 60629" },
    new Customer { Id = 2, Name = "Sophia Davis", Address = "798 Spruce Court, San Diego, IL 31275" },
    new Customer { Id = 3, Name = "Olivia Brown", Address = "608 Willow Way, San Diego, CA 28038" },
    new Customer { Id = 4, Name = "Mason Garcia", Address = "744 Walnut Place, Los Angeles, CA 91363" },
    new Customer { Id = 5, Name = "Ava Brown", Address = "229 Willow Way, Philadelphia, TX 64279" },
    new Customer { Id = 6, Name = "Sophia Williams", Address = "333 Walnut Place, San Antonio, CA 36619" },
    new Customer { Id = 7, Name = "Sophia Davis", Address = "148 Pine Drive, Philadelphia, TX 73717" },
    new Customer { Id = 8, Name = "Logan Davis", Address = "643 Maple Street, Houston, PA 82589" }
};
List<Topping> toppings = new List<Topping>()
{
    new Topping { Id = 1, Name = "Pepperoni" },
    new Topping { Id = 2, Name = "Mushrooms" },
    new Topping { Id = 3, Name = "Onions" },
    new Topping { Id = 4, Name = "Sausage" },
    new Topping { Id = 5, Name = "Bacon" },
    new Topping { Id = 6, Name = "Extra cheese" },
    new Topping { Id = 7, Name = "Black olives" },
    new Topping { Id = 8, Name = "Green peppers" },
    new Topping { Id = 9, Name = "Pineapple" },
    new Topping { Id = 10, Name = "Spinach" }
};
List<TuberDriver> drivers = new List<TuberDriver>()
{
    new TuberDriver { Id = 1, Name = "John Doe" },
    new TuberDriver { Id = 2, Name = "Jane Smith" },
    new TuberDriver { Id = 3, Name = "Alex Johnson" }
};
List<TuberOrder> orders = new List<TuberOrder>()
{
    new TuberOrder { Id = 1, OrderPlacedOnDate = new DateTime(2023, 3, 8), CustomerId = 2, TuberDriverId = 1, DeliveredOnDate = new DateTime(2023, 11, 10) },
    new TuberOrder { Id = 2, OrderPlacedOnDate = new DateTime(2023, 3, 12), CustomerId = 1, TuberDriverId = 2, DeliveredOnDate = new DateTime(2023, 11, 10) },
    new TuberOrder { Id = 3, OrderPlacedOnDate = new DateTime(2023, 9, 5), CustomerId = 7, TuberDriverId = 3, DeliveredOnDate = new DateTime(2023, 11, 10) },
    new TuberOrder { Id = 4, OrderPlacedOnDate = new DateTime(2023, 4, 15), CustomerId = 4, TuberDriverId = 2, DeliveredOnDate = new DateTime(2023, 11, 10) },
    new TuberOrder { Id = 5, OrderPlacedOnDate = new DateTime(2023, 2, 20), CustomerId = 5, TuberDriverId = 1, DeliveredOnDate = new DateTime(2023, 11, 10) },
    new TuberOrder { Id = 6, OrderPlacedOnDate = new DateTime(2023, 1, 10), CustomerId = 3, TuberDriverId = 1, DeliveredOnDate = new DateTime(2023, 11, 11) },
    new TuberOrder { Id = 7, OrderPlacedOnDate = new DateTime(2023, 5, 22), CustomerId = 6, TuberDriverId = 3, DeliveredOnDate = new DateTime(2023, 11, 12) },
    new TuberOrder { Id = 8, OrderPlacedOnDate = new DateTime(2023, 6, 30), CustomerId = 8, TuberDriverId = 3, DeliveredOnDate = new DateTime(2023, 11, 12) },
    new TuberOrder { Id = 9, OrderPlacedOnDate = new DateTime(2023, 7, 14), CustomerId = 4, TuberDriverId = 2, DeliveredOnDate = new DateTime(2023, 11, 13) },
    new TuberOrder { Id = 10, OrderPlacedOnDate = new DateTime(2023, 8, 5), CustomerId = 2, TuberDriverId = 1, DeliveredOnDate = new DateTime(2023, 11, 13) },
    new TuberOrder { Id = 11, OrderPlacedOnDate = new DateTime(2023, 10, 11), CustomerId = 1, TuberDriverId = 1, DeliveredOnDate = new DateTime(2023, 11, 13) },
    new TuberOrder { Id = 12, OrderPlacedOnDate = new DateTime(2023, 11, 20), CustomerId = 5, TuberDriverId = 3, DeliveredOnDate = new DateTime(2023, 11, 14) },
    new TuberOrder { Id = 13, OrderPlacedOnDate = new DateTime(2023, 12, 2), CustomerId = 3, TuberDriverId = 2, DeliveredOnDate = new DateTime(2023, 11, 14) },
    new TuberOrder { Id = 14, OrderPlacedOnDate = new DateTime(2023, 1, 8), CustomerId = 7, TuberDriverId = 2, DeliveredOnDate = new DateTime(2023, 11, 14) },
    new TuberOrder { Id = 15, OrderPlacedOnDate = new DateTime(2023, 2, 17), CustomerId = 8, TuberDriverId = 1, DeliveredOnDate = new DateTime(2023, 11, 14) },
    new TuberOrder { Id = 16, OrderPlacedOnDate = new DateTime(2023, 3, 25), CustomerId = 6, TuberDriverId = 3, DeliveredOnDate = new DateTime(2023, 11, 15) },
    new TuberOrder { Id = 17, OrderPlacedOnDate = new DateTime(2023, 4, 30), CustomerId = 4, TuberDriverId = 3 },
    new TuberOrder { Id = 18, OrderPlacedOnDate = new DateTime(2023, 6, 15), CustomerId = 2, TuberDriverId = 2 },
    new TuberOrder { Id = 19, OrderPlacedOnDate = new DateTime(2023, 7, 21), CustomerId = 1, TuberDriverId = 1 },
    new TuberOrder { Id = 20, OrderPlacedOnDate = new DateTime(2023, 8, 8), CustomerId = 5 }
};

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//add endpoints here

app.Run();
//don't touch or move this!
public partial class Program { }