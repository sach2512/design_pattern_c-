using Dependencyinjection.cs.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Dependencyinjection.cs.Controllers
{
    public class propertydiinject : Controller
    {
        public Employeefetch _Employeefetch { get; set; }

        //public Employeefetch Employeefetch
        //{
        //    set
        //    {
        //        this._Employeefetch = value;
        //    }
        //} // this is etting value manually which is not needed in asp.net core
        public IActionResult Index()
        {
            var list = _Employeefetch.GetEmployeeList();
            return View();
        }
    }
}
