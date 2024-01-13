using Domain.Entities;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
        void AddUser(User user);
    }
}
