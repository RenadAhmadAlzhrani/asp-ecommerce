using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Databases;
using CodeCrafters_backend_teamwork.src.DTOs;
using CodeCrafters_backend_teamwork.src.Entities;
using System.Linq;


namespace CodeCrafters_backend_teamwork.src.Repositories;

public class UserRepository : IUserRepository
{
     private IEnumerable<User> _users;
     private DatabaseContext _databaseContext;
     public UserRepository(DatabaseContext databaseContext)
     {
          _users = new DatabaseContext().Users;
         _databaseContext = databaseContext;
     }

     public IEnumerable<User> FindMany()
     {
          return _users;
     }
     public User CreateOne(User user)
     {
          //_users.Add(user); uncomment for later use of db 
          // _databaseContext.SaveChanges();
          _users = _users.Append(user); //this will be removed later 
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

 public bool DeleteOne(Guid id)
    {
        User user = FindOne(id);
        if (user is null) return false;
        _users.Remove(user);
        _databaseContext.SaveChanges();
        return true;
    }

    private User? FindOne(Guid userId)
    {
        throw new NotImplementedException();
    }


    public User DeleteOne(User userId)
    {
        throw new NotImplementedException();
    }
}
