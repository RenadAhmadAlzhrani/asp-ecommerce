
using System.ComponentModel.DataAnnotations;

namespace CodeCrafters_backend_teamwork.src.Entities
{
    public class OrderItem
    {
        [Key, Required]
        public Guid Id { get; set; }
        [Required]
        public Guid OrderCheckoutId { get; set; }
        [Required]
        public Guid StockId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }

    }
}
