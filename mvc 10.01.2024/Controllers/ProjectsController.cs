using Microsoft.AspNetCore.Mvc;
using mvc_10._01._2024.Data;
using System.Linq;

namespace mvc_10._01._2024.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Project
        public IActionResult Index()
        {
            return View(_context.Projects.ToList());
        }
    }
}
