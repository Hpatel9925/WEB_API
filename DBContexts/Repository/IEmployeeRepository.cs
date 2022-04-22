using DBContexts.Models;

namespace DBContexts.Repository
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetAll();
    }
}
