using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi2;

namespace WebAPITwo.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            List<Employee> employeeLsit = new List<Employee>();

            employeeLsit.Add(new Employee { Address = "Lucknow", Id = 1, Name = "Dipakshi" });
            employeeLsit.Add(new Employee { Address = "Lucknow", Id = 2, Name = "Aditya" });
            employeeLsit.Add(new Employee { Address = "Gurgaon", Id = 3, Name = "Devanshi" });
            employeeLsit.Add(new Employee { Address = "Sitapur", Id = 4, Name = "Akshat" });
            employeeLsit.Add(new Employee { Address = "Calcutta", Id = 5, Name = "Adarsh" });

            return employeeLsit;
        }
    }
}