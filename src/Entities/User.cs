namespace CodeCrafters_backend_teamwork.src.Entities;

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Id { get; }  
        public int? PhoneNumber { get; set; }

        public User(string id, string firstName, string lastName, string password, string email, int phoneNumber)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;

        }

    }
