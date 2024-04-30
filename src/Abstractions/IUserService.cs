using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Abstractions
{
    public interface IUserService
    {
        public List<User> FindMany();
        public User CreateOne(User user);
        public User? FindOneByEmail(string email); 
        public User UpdateOne(string email, User newValue); 
    }
}