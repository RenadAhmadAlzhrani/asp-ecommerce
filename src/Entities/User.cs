using CodeCrafters_backend_teamwork.src.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CodeCrafters_backend_teamwork.src.Entities;

[Index(nameof(Email), IsUnique = true)]
// public class User()
// {
//     internal Guid userId;

//     public string FirstName { get; set; } 
//     public string LastName { get; set; }
//     public string Password { get; set; } 
//     public string Email { get; set; } 
//     public Guid Id { get; set; } 
//     public string PhoneNumber { get; set; } 
      

// }

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public int Id { get; set; }
    public string PhoneNumber { get; set; }
    public string Role {get; set; } 
}