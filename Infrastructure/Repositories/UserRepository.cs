using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
        public class UserRepository : IUserRepository
        {
            private readonly UserContext _context;

            public UserRepository(UserContext context)
            {
                _context = context;
            }

            public void AddUser(User user)
            {
                _context.User.Add(user);
            }
        }
}
