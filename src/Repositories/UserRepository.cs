using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Databases;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Repositories;

public class UserRepository : IUserRepository
{
     private IEnumerable<User> _users;
     public UserRepository()
     {
          _users = new DatabaseContext().users;
     }

     public IEnumerable<User> FindMany()
     {
          return _users;
     }
     public User CreateOne(User user)
     {
         _users = _users.Append(user);
          return user;
     }

     public User? FindOneByEmail(string email)
     {
          User? user = _users.FirstOrDefault(user => user.Email == email);
          return user;
     }

     public User UpdateOne(User updatedUser)
     {
          var users = _users.Select(user =>
           {
                if (user.Email == updatedUser.Email)
                {
                     return updatedUser;

                }
                return user;
           });

          _users = users.ToList();
          return updatedUser;

     }

}
