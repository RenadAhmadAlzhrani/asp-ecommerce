// namespace CodeCrafters_backend_teamwork.src.Entities;


// public class User(int id, string firstName, string lastName, string password, string email, int phoneNumber)
// {
//     public string FirstName { get; set; } = firstName;
//     public string LastName { get; set; } = lastName;
//     public string Password { get; set; } = password;
//     public string Email { get; set; } = email;
//     public int Id { get; set; } = id;
//     public int PhoneNumber { get; set; } = phoneNumber;

// }

using CodeCrafters_backend_teamwork.src.Entities;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public Guid Id { get; set; }
    public string PhoneNumber { get; set; }
    public List<OrderCheckout>? OrderCheckouts { get; set; }
}

