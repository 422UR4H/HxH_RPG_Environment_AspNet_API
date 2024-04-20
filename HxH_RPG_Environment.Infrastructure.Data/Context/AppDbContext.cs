using HxH_RPG_Environment.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HxH_RPG_Environment.Infrastructure.Data.Context;

public class AppDbContext() : DbContext
{
  // public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
  
  public DbSet<ExperienceModel> Experiences { get; set; }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    // base.OnModelCreating(builder);
    // builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    builder.Entity<ExperienceModel>().HasKey(e => e.Id);
  }

  protected override void OnConfiguring(DbContextOptionsBuilder builder)
  {
    // builder.UseSqlServer("Your Connection String");
    var connectionString = "Host=postgres;Port=5432;Username=postgres;Password=postgres;Database=postgres";
    builder.UseNpgsql(connectionString);
  }
}