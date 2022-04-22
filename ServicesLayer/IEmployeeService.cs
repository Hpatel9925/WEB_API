using DBContexts.Models;

namespace ServicesLayer
{
    public interface IEmployeeService
    {
        public List<Employee> GetAllEmployee();
    }
}
