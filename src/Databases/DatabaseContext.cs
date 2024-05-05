
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
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

    public DatabaseContext (IConfiguration config)
    {
        _config=config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@$"Host=localhost;Username=postgres;Database=ecommerce;Password=235552")
        .UseSnakeCaseNamingConvention();

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {

    //     optionsBuilder.UseNpgsql(@$"Host={_config["Db:localhost"]};Username={_config["Db:postgres"]};Database={_config["Db:ecommerce"]};Password={_config["Db:235552"]}")
    //     .UseSnakeCaseNamingConvention();
       
    // }


}
