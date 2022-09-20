using Models;
using Repositories;
using Services;
using Microsoft.EntityFrameworkCore;

//appln objc creation
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<FoodieContext>((options) => options.UseSqlServer(@"server=.\MSSQLSERVER_2;Initial Catalog=Foodie; Integrated Security=True"));
builder.Services.AddScoped<IUserService, Services.UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();



var app = builder.Build(); //appln obj is ready

// Configure the HTTP request pipeline.

app.UseAuthorization(); //Middleware Function will be called only when  get,post request is entered in url

app.MapControllers(); //Middleware Function which calls the controller class

app.Run();
