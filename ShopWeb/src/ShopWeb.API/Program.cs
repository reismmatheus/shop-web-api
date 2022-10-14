using MediatR;
using Microsoft.EntityFrameworkCore;
using ShopWeb.Application.Business;
using ShopWeb.Application.Interface;
using ShopWeb.Domain.Commands.Customer.Add;
using ShopWeb.Domain.Commands.Customer.Update;
using ShopWeb.Domain.Commands.Products.Add;
using ShopWeb.Domain.Interfaces;
using ShopWeb.Domain.Queries.Customer.Get;
using ShopWeb.Domain.Queries.Customer.GetAll;
using ShopWeb.Domain.Queries.Product.Get;
using ShopWeb.Domain.Queries.Product.GetAll;
using ShopWeb.Infra.Data.Context;
using ShopWeb.Infra.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

var sqlConnectionString = builder.Configuration.GetValue<string>("ConnectionStrings:Sql");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ShopWebContext>(options => options.UseSqlServer(sqlConnectionString));

builder.Services.AddTransient<IProductBusiness, ProductBusiness>();
builder.Services.AddTransient<ICustomerBusiness, CustomerBusiness>();

builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();

builder.Services.AddMediatR(new Type[]
{
    typeof(AddCustomerCommand),
    typeof(UpdateCustomerCommand),
    typeof(AddProductCommand),
    typeof(UpdateCustomerCommand),
    typeof(GetAllProductsQuery),
    typeof(GetProductQuery),
    typeof(GetAllCustomersQuery),
    typeof(GetCustomerQuery)
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
