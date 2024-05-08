using CodeCrafters_backend_teamwork.src.Entities;
using CodeCrafters_backend_teamwork.src.Enums;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace CodeCrafters_backend_teamwork.src.Databases;
public class DatabaseContext : DbContext
{

    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Stock> Stocks { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    private IConfiguration _config;
    public IEnumerable<OrderCheckout> OrderCheckouts { get; }
    public DbSet<Category> Category { get; set; }
    public DatabaseContext()
    {

        OrderCheckouts =
        [
        ];
    }

    public DatabaseContext(IConfiguration config)
    {
        _config = config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        var dataSourceBuilder = new NpgsqlDataSourceBuilder(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};
        Database={_config["Db:Database"]};Password={_config["Db:Password"]}");
        dataSourceBuilder.MapEnum<Role>();
        var dataSource = dataSourceBuilder.Build();

        optionsBuilder.UseNpgsql(dataSource).UseSnakeCaseNamingConvention();

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresEnum<Role>();
    }


}
