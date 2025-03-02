using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MTS.Data;
using MTS.Models;

namespace StudentProgrammingTrainingSystem.Controllers
{
    [Authorize(Roles = "Trainer")]
    public class TrainerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrainerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManageTasks()
        {
            var tasks = _context.Tasks.ToList();
            return View(tasks);
        }

        public IActionResult ReviewSubmissions()
        {
            var submissions = _context.Submissions.Include(s => s.Student).Include(s => s.Task).ToList();
            return View(submissions);
        }

        public IActionResult GenerateReports()
        {
            return View();
        }
    }
}