
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Controllers;
using CodeCrafters_backend_teamwork.src.Entities;
using CodeCrafters_backend_teamwork.src.Enums;

using CodeCrafters_backend_teamwork.src.Controllers;

using CodeCrafters_backend_teamwork.src.Entities;
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
    public IEnumerable<OrderCheckout> orderCheckouts { get; }
    public DbSet<Category> Category { get; set; }
    public DatabaseContext()
    {

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
    {

        optionsBuilder.UseNpgsql(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};Database={_config["Db:Database"]};Password={_config["Db:Password"]}")
       .UseSnakeCaseNamingConvention();
    }



    //for DB ef core implementation:
    protected override void onConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql().UseSnakeCaseNamingConvention();

        var dataSourceBuilder = new NpgsqlDataSourceBuilder(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};
        Database={_config["Db:Database"]};Password={_config["Db:Password"]}");
        dataSourceBuilder.MapEnum<Role>();
        var dataSource = dataSourceBuilder.Build();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresEnum<Role>();
    }

    internal void SaveChanges()
    {
        throw new NotImplementedException();
    }
}
