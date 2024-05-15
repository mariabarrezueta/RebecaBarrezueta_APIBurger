using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using RebecaBarrezueta_APIBurger.Data;
//using RebecaBarrezueta_APIBurger.Controllers;
var builder = WebApplication.CreateBuilder(args);
//using RebecaBarrezueta_APIBurger.Controllers;
builder.Services.AddDbContext<RebecaBarrezueta_APIBurgerContext>(options =>
//using RebecaBarrezueta_APIBurger.Controllers;
    options.UseSqlServer(builder.Configuration.GetConnectionString("RebecaBarrezueta_APIBurgerContext") ?? throw new InvalidOperationException("Connection string 'RebecaBarrezueta_APIBurgerContext' not found.")));

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

app.MapControllers();


app.Run();
