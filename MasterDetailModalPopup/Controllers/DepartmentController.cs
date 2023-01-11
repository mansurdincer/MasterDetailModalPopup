using MasterDetailModalPopup.Data;
using MasterDetailModalPopup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MasterDetailModalPopup.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public DepartmentController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            List<Department> departments = _dbContext.Departments.Include(e => e.Employees).ToList();
            return View(departments);
        }

        public IActionResult Create()
        {
            Department department = new Department();

            //Employee employee = (new Employee { Id = 1});

            department.Employees.Add(new Employee { Id = 4 });

            return PartialView("_AddDepartmentPartialView", department);
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            _dbContext.Departments.Add(department);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
