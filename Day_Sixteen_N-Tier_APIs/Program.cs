using Microsoft.EntityFrameworkCore;
using Day_Sixteen_N_Tier_APIs.Data;
using Day_Sixteen_N_Tier_APIs.Repositories;
using Day_Sixteen_N_Tier_APIs.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//registering our AppDbConxtext with Dependency injection | we use SQLite | letting EFCore know we are using SQLite|
//getting our connection string location| tells EFCore where our Database is
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
//whenever anyone asks for an ISupplyRepository, give them SupplyRepository
builder.Services.AddScoped<ISupplyRepository, SupplyRepository>();
builder.Services.AddScoped<ISupplyService, SupplyService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
