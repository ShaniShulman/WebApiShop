using Entities;

namespace Repositories
{
    public interface IUserRepository
    {
        User Post(User user);
        User PostLoginR(string username, string password);
        void Put(int id, User user1);//
    }
}