using Microsoft.EntityFrameworkCore;
using Models;
using Repositories;
using Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors();
builder.Services.AddControllers();

builder.Services.AddDbContext<RestaurantContext>((options) => options.UseSqlServer(@"server=.\MSSQLSERVER_2;Initial Catalog=Foodie; Integrated Security=True"));
builder.Services.AddScoped<IRestaurantOwnerService, RestaurantOwnerService>();
builder.Services.AddScoped<IRestaurantRepository, RestaurantRepository>();

// Item Context Declaration


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
