using HxH_RPG_Environment.API.Services;
using HxH_RPG_Environment.Infrastructure.Data;
using HxH_RPG_Environment.Infrastructure.Data.Context;
// using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddDbContextPool<AppDbContext>(options =>
// {
//     string host = builder.Configuration["Database:Host"] ?? string.Empty;
//     string port = builder.Configuration["Database:Port"] ?? string.Empty;
//     string username = builder.Configuration["Database:Username"] ?? string.Empty;
//     string database = builder.Configuration["Database:Database"] ?? string.Empty;
//     string password = builder.Configuration["Database:Password"] ?? string.Empty;

//     string connectionString = $"Host={host};Port={port};Username={username};Password={password};Database={database}";
//     options.UseNpgsql(connectionString);
// });
// builder.Services.AddDbContextPool<AppDbContext>();
// builder.Services.ConfigureDbApp(builder.Configuration);
builder.Services.ConfigureDbApp();

// Add services to the container.
builder.Services.AddScoped<HealthService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var serviceScope = app.Services.CreateScope();
var dataContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
dataContext?.Database.EnsureCreated();

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
