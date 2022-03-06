using Microsoft.EntityFrameworkCore;
using Parking.Core;
using Parking.Infrastructure;
using Parking.Infrastructure.DataBase;
using Parking.SharedKernel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var configuration = builder.Configuration;
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastracture(configuration);
builder.Services.AddCore();
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