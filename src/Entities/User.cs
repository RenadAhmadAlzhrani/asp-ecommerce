using Microsoft.AspNetCore.Identity;

namespace CodeCrafters_backend_teamwork.src.Entities;

public class User(int id, string firstName, string lastName, string password, string email, string phoneNumber)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public string Password { get; set; } = password;
    public string Email { get; set; } = email;
    public int Id { get; set; } = id;
    public string PhoneNumber { get; set; } = phoneNumber;
    // public Role role {get; set; } = Role.Customer;

}
