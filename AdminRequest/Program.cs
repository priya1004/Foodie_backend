using Microsoft.EntityFrameworkCore;
using Models;
using Repositories;
using Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AdminContext>((options) => options.UseSqlServer(@"server=.\MSSQLSERVER_2;Initial Catalog=Foodie; Integrated Security=True"));
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IAdminRepo, AdminRepo>();

//RestaurantOwnerRequest


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
