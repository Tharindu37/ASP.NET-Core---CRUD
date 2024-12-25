using crud.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Day 4
//builder.Services.AddSingleton<IProductRepository, ProductService>();// Only one instance for application
builder.Services.AddScoped<IProductRepository, ProductService>(); // New Object is created for request
//builder.Services.AddTransient<IProductRepository, ProductService>(); // Always a new object is presented

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
