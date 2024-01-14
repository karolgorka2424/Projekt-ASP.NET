using Microsoft.AspNetCore.Mvc;
using mvc_10._01._2024.Data;
using System.Linq;

namespace mvc_10._01._2024.Controllers
{
    public class CommentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CommentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Comment
        public IActionResult Index()
        {
            return View(_context.Comments.ToList());
        }
    }
}
