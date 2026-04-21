using EFCore_DB_FirstApproach_4DBConnection.Interfaces;
using EFCore_DB_FirstApproach_4DBConnection.MidlandModels;
using EFCore_DB_FirstApproach_4DBConnection.NorthwindDBModels;
using EFCore_DB_FirstApproach_4DBConnection.Repository;
using EFCore_DB_FirstApproach_4DBConnection.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();


builder.Services.AddDbContext<MidlandContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("MIDLandDBFirstApproachDatabase")));

builder.Services.AddDbContext<NorthwindDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("NorthWindDBFirstApproach")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
