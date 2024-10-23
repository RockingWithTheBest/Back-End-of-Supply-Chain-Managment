//using Microsoft.EntityFrameworkCore;
using Back_End.Repositories.Implementation;
using Back_End.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using SupplyChain.Repository.Implementation;
using SupplyChain.Repository.Interface;
using xx1.Db;
using xx1.Repository.Implementation;
using xx1.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//JSON Serializer
builder.Services.AddControllers().AddNewtonsoftJson(options =>
options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore).AddNewtonsoftJson(
    options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

//Dependancy injection
builder.Services.AddDbContext<ApplicationDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SupplyChainDBString")));

// Register ITrying with its implementation
builder.Services.AddScoped<IProduct, ProductRepository>();
builder.Services.AddScoped<ICheque, ChequeRepositiory>();
builder.Services.AddScoped<ICash, CashRepository>();
builder.Services.AddScoped<IOrder, OrderRepository>();
builder.Services.AddScoped<ICustomer, CustomerRepository>();
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();


//Enable CORS ~ so that the service can be consumed from the front end of the project
app.UseCors(c => c.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());



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
