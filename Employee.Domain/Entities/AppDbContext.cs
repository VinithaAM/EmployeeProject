using Microsoft.EntityFrameworkCore;


namespace Employee.Domain.Entities
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> TblEmployeeDetails { get; set; }
    }
}
