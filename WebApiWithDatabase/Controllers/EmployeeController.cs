using Microsoft.AspNetCore.Mvc;
using ServicesLayer;
using DBContexts.Models;
using System.Diagnostics;

namespace WebApiWithDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;
     
        public EmployeeController(IEmployeeService service)
        {
            _employeeService = service;
        }
        [HttpGet]
        public List<Employee> GetEmployees()
        {
            try
            {
                return _employeeService.GetAllEmployee();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
