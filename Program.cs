using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RebecaBarrezueta_APIBurger.Data;
using RebecaBarrezueta_APIBurger.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Configuración del contexto de la base de datos
builder.Services.AddDbContext<RebecaBarrezueta1004WebApplication1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RebecaBarrezueta1004WebApplication1Context") ?? throw new InvalidOperationException("Connection string 'RebecaBarrezueta1004WebApplication1Context' not found.")));

// Agregar servicios al contenedor
builder.Services.AddControllers();

// Configuración de Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "RebecaBarrezueta_API Burger", Version = "v1" });
});

var app = builder.Build();

// Configuración del pipeline de solicitudes HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RebecaBarrezueta_API Burger v1"));
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

// Mapeo de los endpoints minimalistas
app.MapBurgerEndpoints();

app.Run();

