using Microsoft.AspNetCore.Mvc;
using ScondDemoModels.Models;

namespace ScondDemoModels.Controllers
{
    public class StudentController: Controller
    {
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddStudent(Student student)
        {
            return View(student);
        }

    }
}
