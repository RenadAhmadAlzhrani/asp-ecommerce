
namespace CodeCrafters_backend_teamwork.src.Entities
{
    public class OrderItem
    {
        public string Id { get; set; }
        public string OrderCheckoutId { get; set; }
        public string StockId { get; set; }
        public int Quantity { get; set; }
        public OrderItem(string orderCheckoutId, string stockId, int quantity)
        {
            Id = Guid.NewGuid().ToString();
            OrderCheckoutId = orderCheckoutId;
            StockId = stockId;
            Quantity = quantity;

        }
    }
}
// rnd