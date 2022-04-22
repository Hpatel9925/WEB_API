using DBContexts.Models;
using Microsoft.EntityFrameworkCore;

namespace DBContexts.DbContexts
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }
        public DbSet<Employee> Employee { get; set; }

    }
}
