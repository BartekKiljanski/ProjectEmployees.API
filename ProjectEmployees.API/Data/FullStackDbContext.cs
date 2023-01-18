using Microsoft.EntityFrameworkCore;
using ProjectEmployees.API.Models;

namespace ProjectEmployees.API.Data
{
    public class FullStackDbContext : DbContext
    {
        public FullStackDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }


    }
}
