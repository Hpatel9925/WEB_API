using DBContexts.Models;
using DBContexts.DbContexts;
using System.Diagnostics;

namespace DBContexts.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeContext _employeeContext;

        public EmployeeRepository(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        // Get all Employee Data from Database
        public List<Employee> GetAll()
        {
            return _employeeContext.Employee.ToList();
        }
    }
}
