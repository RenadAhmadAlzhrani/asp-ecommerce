
using CodeCrafters_backend_teamwork.src.Controllers;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Databases;
public class DatabaseContext
{
    public IEnumerable<Category> category { get; }
    public IEnumerable<Product> products { get; }
    public IEnumerable<User> users { get; }
    public IEnumerable<Stock> stocks { get; }

    public DatabaseContext()
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

        orderItem = [
            new OrderItem (34,"{orderCheckoutId}","{stockId}",4)
        ];

    }
}
