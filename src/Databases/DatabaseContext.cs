
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
    public DatabaseContext (IConfiguration config)
    {
        category =
        [
            new Category("Channel"),
            new Category("miu miu"),
            new Category("Gucci")
        ];
        products = [
            new Product("bag", "pic1", 44.5),
            new Product("purse", "pic2", 44.5),
            new Product("shirt", "pic3", 44.5)
             ];

        stocks = [
            new Stock("bag", "pic1", "44.5")
            ];

        users = [
            new User(12, "Aishah", "AlSaud" , "123456" , "Aishah@gmail.com", 0544444444),
            new User(12,  "Renad", "AlZahrani", "654321",  "Renad@gmail.com", 0533333344),
            new User(12, "Raneem", "AlMutairi", "098765", "Raneem@gmail.com", 0555555544),
            new User(12,  "Bashayer", "AlWahbi", "567890", "Bashayer@gmail.com", 0566666644)

        ];

        orderCheckouts =
        [
            new OrderCheckout(new DateTime(2023, 3, 1),12,12432,000557699,"Confirmed",10.000)
        ];

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
