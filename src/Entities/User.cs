using CodeCrafters_backend_teamwork.src.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CodeCrafters_backend_teamwork.src.Entities;

[Index(nameof(Email), IsUnique = true)]
public class User(Guid id, string firstName, string lastName, string password, string email, string phoneNumber, string Role)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public string Password { get; set; } = password;
    public string Email { get; set; } = email;
    public Guid Id { get; set; } = Guid.NewGuid();
    public string PhoneNumber { get; set; } = phoneNumber;
     public string Role {get; set; } //string

}
