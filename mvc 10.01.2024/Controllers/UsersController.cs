using Microsoft.AspNetCore.Mvc;
using mvc_10._01._2024.Data;
using System.Linq;

namespace mvc_10._01._2024.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: User
        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }
    }
}
