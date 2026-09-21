//builder - this configures our web api before the app runs
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Without controllers we would NOT be able to use them
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

//this allows us to view our information in json format
builder.Services.AddOpenApi();

//builder.Build after this nothing can be added to our app (app is officially built)
var app = builder.Build();

// Configure the HTTP request pipeline.

//if our app is in development we can open API
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();//this turns incoming request to our controllers

app.Run();// this runs our program
