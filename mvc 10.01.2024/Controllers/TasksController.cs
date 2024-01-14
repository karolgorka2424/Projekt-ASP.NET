using Microsoft.AspNetCore.Mvc;
using mvc_10._01._2024.Data;
using System.Linq;

namespace mvc_10._01._2024.Controllers
{
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaskController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Task
        public IActionResult Index()
        {
            return View(_context.Tasks.ToList());
        }
    }
}
