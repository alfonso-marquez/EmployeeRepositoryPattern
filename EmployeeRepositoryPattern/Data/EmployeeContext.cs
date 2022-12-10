using Microsoft.EntityFrameworkCore;
using EmployeeRepositoryPattern.Models;



namespace EmployeeRepositoryPattern.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options)
        { 

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
