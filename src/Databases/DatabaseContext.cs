
using CodeCrafters_backend_teamwork.src.Controllers;

using CodeCrafters_backend_teamwork.src.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeCrafters_backend_teamwork.src.Databases;
public class DatabaseContext : DbContext
{

    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Stock> Stocks { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    private IConfiguration _config;
    public DbSet<OrderCheckout> OrderCheckouts { get; set; }
    public DbSet<Category> Category { get; set; }

    public DatabaseContext(IConfiguration config)
    {
        _config = config;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseNpgsql(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};Database={_config["Db:Database"]};Password={_config["Db:Password"]}")
       .UseSnakeCaseNamingConvention();
    }

}
