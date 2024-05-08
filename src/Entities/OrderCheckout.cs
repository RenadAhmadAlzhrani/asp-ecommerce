using System.ComponentModel.DataAnnotations;

namespace CodeCrafters_backend_teamwork.src.Entities;

public class OrderCheckout
{
    [Key, Required]
    public Guid Id { get; set; }

    [Required]
    public Guid PaymentId { get; set; }
    [Required]
    public Guid UserId { get; set; }
    [Required]
    public Guid ShippingId { get; set; }
    [MaxLength(50), Required]

    public string Status { get; set; }
    [Required]
    public double TotalPrice { get; set; }
    public List<OrderItem> OrderItems { get; set; }

}

