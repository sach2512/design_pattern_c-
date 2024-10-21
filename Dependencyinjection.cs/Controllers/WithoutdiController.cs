using Dependencyinjection.cs.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dependencyinjection.cs.Controllers
{
    public class WithoutdiController : Controller
    {
        private readonly ILogger<WithoutdiController> _logger;

        public WithoutdiController(ILogger<WithoutdiController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var Employeedal= new Employeedal();
            var list = Employeedal.selectallemployee(); // we are creating instance of dependt class 
            // that means they are tightly coupled 
            // insetad of layer we can fetch directly here also that is alsi a tight couple 
            // we are directly coupling dataftech and controlelr and nmodel and controler becomes tight coupled

            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
