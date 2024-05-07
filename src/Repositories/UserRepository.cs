using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Databases;
using CodeCrafters_backend_teamwork.src.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeCrafters_backend_teamwork.src.Repositories;

public class UserRepository : IUserRepository
{
     private DbSet<User> _users;
     private DatabaseContext _databaseContext;
     public UserRepository(DatabaseContext databaseContext)
     {
          _databaseContext = databaseContext;

          _users = databaseContext.Users;
     }

     public IEnumerable<User> FindMany()
     {
          return _users;
     }
     public User CreateOne(User user)
     {
          _users.Add(user);  
          _databaseContext.SaveChanges(); 
          return user;
     }

     public User? FindOneByEmail(string email)
     {
          User? user = _users.FirstOrDefault(user => user.Email == email);
          return user;
     }

     public User UpdateOne(User updatedUser)
     {
          _users.Update(updatedUser);
          _databaseContext.SaveChanges();
          return updatedUser;
           }

    public IEnumerable<User> DeleteOne(Guid userId)
    {
        throw new NotImplementedException();
    }


     public User? DeleteOne(Guid userId)
     {
          var deleteUser = FindOne(userId);
        _ = _users.Where(user => deleteUser.userId == userId);
          _databaseContext.SaveChanges();
          return deleteUser;
     }

     private User? FindOne(Guid userId)
     {
          throw new NotImplementedException();
     }


     public User DeleteOne(User userId)
     {
          throw new NotImplementedException();
     }

    IEnumerable<User> IUserRepository.DeleteOne(Guid id)
    {
        throw new NotImplementedException();
    }
}
