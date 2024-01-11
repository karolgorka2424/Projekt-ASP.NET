using Microsoft.AspNetCore.Mvc;

namespace mvc_10._01._2024.Controllers
{
    public class CommentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
