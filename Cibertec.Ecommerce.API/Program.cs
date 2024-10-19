using Cibertec.Domain.Infraestructure.Context;
using Cibertec.Domain.Infraestructure.Repositories;
using Cibertec.Ecommerce.Application;
using Cibertec.Ecommerce.Application.Abstractions;
using Cibertec.Ecommerce.Domain;
using Cibertec.Ecommerce.Domain.Validators;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICustomerRepository,CustomerDBRepository>();
builder.Services.AddScoped<IValidator<Customer>,CustomerValidator>();


var cs = builder.Configuration.GetConnectionString("EcommerceDB");

builder.Services.AddDbContext<EcommerceDBContext>(x => x.UseSqlServer(cs, b => b.MigrationsAssembly("Cibertec.Ecommerce.API")));
//builder.Services.AddDbContext<EcommerceDBContext>(x => x.UseSqlServer(cs, b => b.MigrationsAssembly("Cibertec.Domain.Infraestructure")));
//builder.UseSqlServer(cs, b => b.MigrationsAssembly("Cibertec.Ecommerce.API"));

builder.Services.AddApplicationDependencies();


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
