using System.ComponentModel.DataAnnotations;

namespace CodeCrafters_backend_teamwork.src.Entities
{
    public class Category
    {
        [Key, Required]
        public Guid Id { get; set; }
        [MaxLength(50), Required]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}