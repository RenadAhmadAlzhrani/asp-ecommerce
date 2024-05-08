using System.ComponentModel.DataAnnotations;
using CodeCrafters_backend_teamwork.src.Enums;
using Microsoft.EntityFrameworkCore;

namespace CodeCrafters_backend_teamwork.src.Entities;

[Index(nameof(Email), IsUnique = true)]
public class User
{
    [MinLength(1), Required]
    public string FirstName { get; set; }
    [MinLength(1), Required]
    public string LastName { get; set; }
    [MinLength(5), Required]
    public string Password { get; set; }
    [MinLength(3), Required]
    public string Email { get; set; }
    [Key, Required]
    public Guid UserId { get; set; }
    [MinLength(5), Required]
    public string PhoneNumber { get; set; }

    public Role Role { get; set; }
}
