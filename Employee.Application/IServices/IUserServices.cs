using Employee.Domain.Entities;


namespace Employee.Application.IServices
{
    public interface IUserServices
    {
        public List<User> GetUsers();
        public User GetUserById(int id);
        public User Create(User user);
        public User Update(User user);
        public bool Delete(int id);
    }
}
