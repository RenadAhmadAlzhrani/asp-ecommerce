
using CodeCrafters_backend_teamwork.src.Controllers;

using CodeCrafters_backend_teamwork.src.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeCrafters_backend_teamwork.src.Databases;
public class DatabaseContext : DbContext
{

    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Stock> Stocks { get; set; }
    private IConfiguration _config;
    public IEnumerable<OrderCheckout> orderCheckouts { get; }
    public IEnumerable<Category> category { get; }
    public DatabaseContext()
    {
        category =
        [
            new Category("Channel"),
            new Category("miu miu"),
            new Category("Gucci")
        ];


        orderCheckouts =
        [
            new OrderCheckout(new DateTime(2023, 3, 1),12,12432,000557699,"Confirmed",10.000)
        ];
    }

    public DatabaseContext(IConfiguration config)
    {
        _config = config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@$"Host=localhost;Username=postgres;Database=ecommerce;Password=235552")
        .UseSnakeCaseNamingConvention();



}
