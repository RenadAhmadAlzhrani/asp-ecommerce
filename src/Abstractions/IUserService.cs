
namespace CodeCrafters_backend_teamwork.src.Abstractions
{
    public interface IUserService
    {
        public IEnumerable<UserReadDto> FindMany();
        public User? CreateOne(User user);
        public UserReadDto? CreateOneTest(UserCreateDto user);
        public UserReadDto? FindOneByEmail(string email);
        public User? UpdateOne(string email, User newValue);
    }
}
