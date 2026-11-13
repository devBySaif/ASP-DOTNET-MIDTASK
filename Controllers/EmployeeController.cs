using Microsoft.AspNetCore.Mvc;
using Practice1.Data;

namespace Practice1.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly AppDbContext _context;
        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {

            var students = _context.Employees.OrderByDescending(s=>s.JoinDate).ToList();
            return View(students);
        }

        public IActionResult SeniorEmployee()
        {
            var seniorEmployees = _context.Employees.Where(e => e.ExprienceYears > 5).OrderByDescending(e => e.Salary).ToList();
            return View(seniorEmployees);
        }

        public IActionResult DepartmentAverage()
        {
            var departmentAverageSalaries = _context.Employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    AverageSalary = g.Average(e => e.Salary)
                })
                .OrderByDescending(d => d.AverageSalary)
                .ToList();
            return View(departmentAverageSalaries);
        }
    }
}
