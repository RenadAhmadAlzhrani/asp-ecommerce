
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Controllers;

using CodeCrafters_backend_teamwork.src.Entities;
using CodeCrafters_backend_teamwork.src.Enums;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace CodeCrafters_backend_teamwork.src.Databases;
public class DatabaseContext
{
    public IEnumerable<Product> Products { get; }
    public IEnumerable<User> Users { get; }
    public IEnumerable<Stock> Stocks { get; } //IConfiguration config

    public DatabaseContext()
    {
        Products = [
            new Product("bag", "pic1", 44.5),
             new Product("purse", "pic2", 44.5),
             new Product("shirt", "pic3", 44.5),
             ];

        Stocks = [
                 new Stock("bag", "pic1", "44.5")
             ];

        Users = [
            new User( "Aishah", "AlSaud" , "123456" , "Aishah@gmail.com", "0544444444", "Customer"),
            new User( "Renad", "AlZahrani", "654321",  "Renad@gmail.com" ,"0533333344","Customer"),
            new User( "Raneem", "AlMutairi", "098765", "Raneem@gmail.com", "0555555544","Admin"),
            new User( "Bashayer", "AlWahbi", "567890", "Bashayer@gmail.com", "0566666644","Admin"),

        ];
        //keep this and delete above later
        // _config = config;
    }

    //for DB ef core implementation:
    // protected override void onConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseNpgsql().UseSnakeCaseNamingConvention();

    //     var dataSourceBuilder = new NpgsqlDataSourceBuilder(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};
    //     Database={_config["Db:Database"]};Password={_config["Db:Password"]}");
    //     dataSourceBuilder.MapEnum<Role>();
    //     var dataSource = dataSourceBuilder.Build();
    // }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.HasPostgresEnum<Role>();
    // }

    internal void SaveChanges()
    {
        throw new NotImplementedException();
    }
}
