using Entities;

namespace Services
{
    public interface IUserService
    {
        int CheckPassword(string password);
        User Post(User user);
        User PostLoginS(string username, string password);
        void Put(int id, User user);
    }
}