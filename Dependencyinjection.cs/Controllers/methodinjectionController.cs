using Dependencyinjection.cs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dependencyinjection.cs.Controllers
{
    public class methodinjectionController : Controller
    {
        public IActionResult Index(Employeefetch fetch) // this is method way to inject 
        {
            var list =fetch.GetEmployeeList().ToList();
            return View();
        }
    }
}
