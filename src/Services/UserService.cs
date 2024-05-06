// using System.Text;
// using AutoMapper;
// using CodeCrafters_backend_teamwork.src.Abstractions;
// using CodeCrafters_backend_teamwork.src.Databases;
// using CodeCrafters_backend_teamwork.src.DTOs;
// using CodeCrafters_backend_teamwork.src.Entities;
// using CodeCrafters_backend_teamwork.src.Utility;

// namespace CodeCrafters_backend_teamwork.src.Services;

// public class UserService : IUserService
// {
//     private IUserRepository _userRepository;
//     private IConfiguration _config;
//     private IMapper _mapper;

//     public UserService(IUserRepository userRepository, IConfiguration config, IMapper mapper)
//     {
//         _userRepository = userRepository;
//         _config = config;
//         _mapper = mapper;
//     }


//     public IEnumerable<UserReadDto> FindMany()
//     {
//         var users = _userRepository.FindMany();
//         var usersRead = users.Select(_mapper.Map<UserReadDto>);
//         return usersRead.ToList();
//     }

    public User? CreateOne(User user) // DOES NOT WROK SHOULD FIX IT 
    {
        var foundUser = _userRepository.FindOneByEmail(user.Email);
        Console.WriteLine($"Create One method triggers");


//         if (foundUser is not null)
//         {
//             Console.WriteLine($"item is found");
//             return null;
//         }
//         byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);

//         PasswordUtils.HashPassword(user.Password, out string hashedPassword,
//         pepper);
//         user.Password = hashedPassword;
//         return _userRepository.CreateOne(user);
//     }

//     public UserReadDto? FindOneByEmail(string email)
//     {
//         User? user = _userRepository.FindOneByEmail(email);
//         UserReadDto? usersRead = _mapper.Map<UserReadDto>(user);
//         return usersRead;

//     }

//     public User? UpdateOne(string email, User newValue)
//     {
//         User? user = _userRepository.FindOneByEmail(email);
//         if (user is not null)
//         {
//             user.FirstName = newValue.FirstName;
//             return _userRepository.UpdateOne(user);
//         }
//         return null;
//     }

    public UserReadDto? CreateOneTest(UserCreateDto user)
    {
        var mappedUser = _mapper.Map<User>(user);

        var foundUser = _userRepository.FindOneByEmail(mappedUser.Email);
        Console.WriteLine($"Create One method triggers");

        if (foundUser is not null)
        {
            Console.WriteLine($"user email is exist in database");
            return null;
        }

        var userCreated = _userRepository.CreateOne(mappedUser);
        return _mapper.Map<UserReadDto>(userCreated);
    }
}

