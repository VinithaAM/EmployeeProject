using Employee.Application.IRepositories;
using Employee.Application.IServices;
using Employee.Domain.Entities;


namespace Employee.Application.Services
{
    public class UserServices(IUserRepository userRepository) : IUserServices
    {
        private readonly IUserRepository _userRepository = userRepository;

        public User Create(User user)
        {
            return _userRepository.Create(user);
        }

        public bool Delete(int id)
        {
            return _userRepository.Delete(id);
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public List<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public User Update(User user)
        {
           return _userRepository.Update(user);
        }
    }
}
