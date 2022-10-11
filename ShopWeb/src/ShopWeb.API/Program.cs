using MediatR;
using Microsoft.EntityFrameworkCore;
using ShopWeb.Application.Business;
using ShopWeb.Application.Interface;
using ShopWeb.Domain.Interfaces;
using ShopWeb.Domain.Queries.Product;
using ShopWeb.Infra.Data.Context;
using ShopWeb.Infra.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

var sqlConnectionString = builder.Configuration.GetValue<string>("ConnectionStrings:Sql");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ShopWebContext>(options => options.UseSqlServer(sqlConnectionString));

builder.Services.AddTransient<IProductBusiness, ProductBusiness>();

builder.Services.AddTransient<IProductRepository, ProductRepository>();

builder.Services.AddMediatR(new Type[]
{
    typeof(GetAllProductsQuery)
    //typeof(CommandsMediatR.UpdateProductUnitPriceCommand),
    //typeof(CommandsMediatR.UpdateProductCurrentStockCommand),
    //typeof(QueriesMediatR.GetProductsByNameQuery),
    //typeof(QueriesMediatR.FindOutOfStockProductsQuery)
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
