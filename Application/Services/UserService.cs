using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepositorySingleton;

        public UserService(IUserRepository userRepository)
        {
            _userRepositorySingleton = userRepository;
        }

        public void AddUser(string nome)
        {
            var newUser = new User(1,nome);
            _userRepositorySingleton.AddUser(newUser);
        }
    }
}
