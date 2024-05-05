using System.Text;
using AutoMapper;
using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Databases;
using CodeCrafters_backend_teamwork.src.DTOs;
using CodeCrafters_backend_teamwork.src.Entities;
using CodeCrafters_backend_teamwork.src.Utility;

namespace CodeCrafters_backend_teamwork.src.Services;

public class UserService : IUserService
{
    private IUserRepository _userRepository;
    private IConfiguration _config;
    private IMapper _mapper;

    public UserService(IUserRepository userRepository, IConfiguration config, IMapper mapper)
    {
        _userRepository = userRepository;
        _config = config;
        _mapper = mapper;
    }


    public IEnumerable<UserReadDto> FindMany()
    {
        var users = _userRepository.FindMany();
        var usersRead = users.Select(_mapper.Map<UserReadDto>);
        return usersRead.ToList();
    }

    public UserReadDto? SignIn(UserSignIn userSign)
    {
        User? user = _userRepository.FindOneByEmail(userSign.Email);
        if (user is null)
        {
            return null;
        }
        byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);

        bool isCorrectPass = PasswordUtils.VerifyPassword(userSign.Password, user.Password, pepper);
        if (!isCorrectPass) return null;

        UserReadDto userRead = _mapper.Map<UserReadDto>(user);
        return userRead;


    }

    public UserReadDto? SignUp(UserCreateDto user)
    {
        var foundUser = _userRepository.FindOneByEmail(user.Email);

        if (foundUser is not null)
        {
            Console.WriteLine($"item is found");
            return null;
        }

        byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);

        PasswordUtils.HashPassword(user.Password, out string hashedPassword,
        pepper);

        user.Password = hashedPassword;
        User mappedUser = _mapper.Map<User>(user);
        User newUser = _userRepository.CreateOne(mappedUser);
        UserReadDto userRead = _mapper.Map<UserReadDto>(newUser);

        return userRead;
    }

    public UserReadDto? FindOneByEmail(string email)
    {
        User? user = _userRepository.FindOneByEmail(email);
        UserReadDto? usersRead = _mapper.Map<UserReadDto>(user);
        return usersRead;

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

    public bool DeleteOne(Guid id)
    {
        return _userRepository.DeleteOne(id);
    }

    // User? IUserService.CreateOne(User user)
    // {
    //     throw new NotImplementedException();
    // }

    // UserReadDto IUserService.DeleteOne(User userId)
    // {
    //     throw new NotImplementedException();
    // }

    public User FindOne(Guid userId)
    {
        throw new NotImplementedException();
    }

    UserReadDto IUserService.FindOne(Guid id)
    {
        throw new NotImplementedException();
    }
}
