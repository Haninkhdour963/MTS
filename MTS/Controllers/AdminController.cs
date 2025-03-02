using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MTS.Data;
using MTS.Models;

namespace StudentProgrammingTrainingSystem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManageTrainers()
        {
            var trainers = _context.Trainers.ToList();
            return View(trainers);
        }

        public IActionResult ManageStudents()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        public IActionResult SystemSettings()
        {
            return View();
        }
    }
}