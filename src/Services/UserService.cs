using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Databases;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Services;

public class UserService : IUserService
{
    private IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }


    public List<User> FindMany()
    {
        return _userRepository.FindMany();
    }


    public User CreateOne(User user)
    {
        User foundUser = _userRepository.FindOneByEmail(user.Email);
        if (foundUser is not null)
        {
            return null;
        }
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
