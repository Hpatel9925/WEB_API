using DBContexts.Models;
using DBContexts.Repository;
using System.Diagnostics;

namespace ServicesLayer
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public List<Employee> GetAllEmployee()
        {
            return _employeeRepository.GetAll().ToList();
        }
    }
}
