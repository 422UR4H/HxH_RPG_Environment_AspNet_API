using HxH_RPG_Environment.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HxH_RPG_Environment.Infrastructure.Data;

// static class?
public static class ServiceExtensions
{
  // static?
  public static IServiceCollection/*void*/ ConfigureDbApp(
    this IServiceCollection services)//,
    // IConfiguration configuration)
  {
    // var connectionString = configuration.GetConnectionString("Sqlite");
    // var connectionString = "Host=postgres;Port=5432;Username=postgres;Password=postgres;Database=postgres";
    // services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(connectionString));
    services.AddDbContext<AppDbContext>();
    // services.AddDbContextPool<AppDbContext>(opt => opt.UseNpgsql(connectionString));
    // services.AddDbContextPool<AppDbContext>(opt => opt.UseNpgsql(connectionString, b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));
    return services;
  }
}
