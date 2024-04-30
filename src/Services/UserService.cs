using System.Text;
using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Databases;
using CodeCrafters_backend_teamwork.src.Entities;
using CodeCrafters_backend_teamwork.src.Utility;

namespace CodeCrafters_backend_teamwork.src.Services;

public class UserService : IUserService
{
    private IUserRepository _userRepository;
    private IConfiguration _config;

    public UserService(IUserRepository userRepository, IConfiguration config)
    {
        _userRepository = userRepository;
        -config = config;
    }


    public List<User> FindMany()
    {
        return _userRepository.FindMany();
    }


    public User? CreateOne(User user)
    {
        User foundUser = _userRepository.FindOneByEmail(user.Email);
        if (foundUser is not null)
        {
            return null;
        }
        byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);

        PasswordUtils.HashPassword(user.Password, out string hashedPassword,
        pepper);
        user.Password = hashedPassword;
        return _userRepository.CreateOne(user);
    }

    public User? FindOneByEmail(string email)
    {
        return _userRepository.FindOneByEmail(email);
    }

    public User? UpdateOne(string email, User newValue)
    {
        User? user = _userRepository.FindOneByEmail(email);
        if (user is not null)
        {
            user.FirstName = newValue.FirstName;
           return _userRepository.UpdateOne(user);
        }
       return null; 
    }
    

}
