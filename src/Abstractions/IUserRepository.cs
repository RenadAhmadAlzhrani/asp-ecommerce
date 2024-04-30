using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Abstractions
{
    public interface IUserRepository
    {
        public  List<User> FindMany();
        public  User CreateOne(User user);
        public User FindOneByEmail(string email);
        public User UpdateOne(User updatedUser);
    }
}