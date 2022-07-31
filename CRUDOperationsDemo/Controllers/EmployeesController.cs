using CRUDOperationsDemo;
using CURDOprationsDimo.Models;
using Microsoft.AspNetCore.Mvc; 
using Microsoft.EntityFrameworkCore;

namespace CURDOprationsDimo.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly CRUDDbContext _context;
        private readonly IWebHostEnvironment env;

        public EmployeesController(CRUDDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            this.env = env;
        }
        public IActionResult Index()
        {

            return View(_context.Employees);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit(int? Id)
        {
            var result = _context.Employees.Find(Id);
            return View("Create", result);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee model)
        {

            if (model != null)
            {
                _context.Employees.Update(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
        public IActionResult Delete(int? Id)
        {
            var result = _context.Employees.Find(Id);
            if (result != null)
            {
                _context.Employees.Remove(result);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
