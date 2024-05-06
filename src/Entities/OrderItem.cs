
namespace CodeCrafters_backend_teamwork.src.Entities
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public string OrderCheckoutId { get; set; }
        public string StockId { get; set; }
        public int Quantity { get; set; }

    }
}
