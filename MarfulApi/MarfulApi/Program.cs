using Microsoft.EntityFrameworkCore;
using MarfulApi.Data;
using MarfulApi.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MarfulDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("sqlServer")));
builder.Services.AddTransient<IContent,ContentRepo>();
builder.Services.AddTransient<IBasket, BasketRepo>();
builder.Services.AddTransient<IBrand, BrandRepo>();
builder.Services.AddTransient<ICompanyContent, ICompanyContent>();
builder.Services.AddTransient<IInfulonser, InfulonserRepo>();
builder.Services.AddTransient<IInfulonserContent, InfulonserContentRepo>();
builder.Services.AddTransient<IInfulonserUser, InfulonserUserRepo>();
builder.Services.AddTransient<IProduct, ProductRepo>();
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
