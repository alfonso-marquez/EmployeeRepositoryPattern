using EmployeeRepositoryPattern.Infrastructure;
using EmployeeRepositoryPattern.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeRepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployee _employee;

        public HomeController(IEmployee employee)
        {
            _employee = employee;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var employees = _employee.GetAll();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _employee.Insert(employee);
            _employee.Save();

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var employee = _employee.GetById(Id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            _employee.Delete(employee);
            _employee.Save();

            return View(employee);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var employee = _employee.GetById(Id);
            return View(employee);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var employee = _employee.GetById(Id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _employee.Update(employee);
            _employee.Save();

            return View(employee);
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