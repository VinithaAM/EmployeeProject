using Employee.Application.IRepositories;
using Employee.Domain.Entities;


namespace Employee.Infrastructure.Repositories
{
    public class UserRepository(AppDbContext context) : IUserRepository
    {
        private readonly AppDbContext _context = context;

        public User Create(User user)
        {
            if(user != null)
            {
                user.CreatedDateTime = DateTime.Now;
                _context.Add(user);
                _context.SaveChanges();
            }
            return user;
        }

        public bool Delete(int id)
        {
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            User user=_context.TblEmployeeDetails.Where(x=>x.Id == id && x.Status==true).FirstOrDefault();
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (user != null)
            {
                user.Status = false;
                user.DeletedDateTime = DateTime.Now;
                _context.Update(user);
                _context.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public User GetUserById(int id)
        {
            return _context.TblEmployeeDetails.Where(x=>x.Id==id && x.Status ==true).FirstOrDefault();
        }

        public List<User> GetUsers()
        {
            return _context.TblEmployeeDetails.Where(x=>x.Status==true).ToList();
        }

        public User Update(User user)
        {
            if(user != null )
            {
                user.ModifiedDateTime = DateTime.Now;
                _context.Update(user);
                _context.SaveChanges();
            }
            return user;
        }
    }
}
