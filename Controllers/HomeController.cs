using HRApplicationnew.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;
using System.Diagnostics;

namespace HRApplicationnew.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
      


        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Employees()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Employees(Employees employee)
        {
            if (ModelState.IsValid)
            {
                Repository.AddEmployee(employee);
                return View("Save", employee);

            }
            else
                return View();
            
        }

        public ViewResult AllEmployees()
        {
            return View(Repository.GetEmployees().Where(emp => emp.IsActive));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
