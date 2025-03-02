using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MTS.Data;
using MTS.Models;

namespace StudentProgrammingTrainingSystem.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewTasks()
        {
            var tasks = _context.Tasks.ToList();
            return View(tasks);
        }

        public IActionResult UploadSubmission(int taskId)
        {
            var task = _context.Tasks.Find(taskId);
            return View(task);
        }

        public IActionResult ReviewFeedback()
        {
            var feedback = _context.Feedbacks.Include(f => f.Submission).ThenInclude(s => s.Task).ToList();
            return View(feedback);
        }
    }
}