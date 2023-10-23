using Microsoft.AspNetCore.Mvc;
using ScondDemoModels.Models;

namespace ScondDemoModels.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddEmployee(Employee employee)
        {
            return View(employee);
        }
    }
}
