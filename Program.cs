using Microsoft.EntityFrameworkCore;
using PrimerAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Junior Barrios - 7690-25-16187
builder.Services.AddDbContext<apiContext>(Options =>
{
    Options.UseMySql(builder.Configuration.GetConnectionString("conexion"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("conexion")));
         
});



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
