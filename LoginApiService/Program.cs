using Microsoft.EntityFrameworkCore;
using Models;
using Repositories;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<LoginContext>((options) => options.UseSqlServer(@"server=.\MSSQLSERVER_2;Initial Catalog=Foodie; Integrated Security=True"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<ILoginRepo, LoginRepo>();
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

app.MapControllers();

app.Run();
