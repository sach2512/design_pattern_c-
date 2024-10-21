using Dependencyinjection.cs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dependencyinjection.cs.Controllers
{
    public class withdiController : Controller
    {
        private Employeefetch _employeeftech;

        public withdiController(Employeefetch employeefetch)
        {
            _employeeftech = employeefetch;
        }
        public IActionResult Index()
        {
            var list = _employeeftech.GetEmployeeList();
            return View();
        }
    }
}
