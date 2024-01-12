using Microsoft.AspNetCore.Mvc;
using mvc_10._01._2024.Models;

namespace mvc_10._01._2024.Controllers
{
    public class UsersController : Controller
    {
        private static List<User> _users = new List<User>();

        public ActionResult Index()
        {
            return View(_users);
        }

        public ActionResult Details(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                user.Id = _users.Count + 1;
                _users.Add(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        public ActionResult Edit(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = _users.FirstOrDefault(u => u.Id == id);
                if (existingUser == null)
                {
                    return NotFound();
                }

                existingUser.Name = user.Name;
                existingUser.Email = user.Email;

                return RedirectToAction("Index");
            }
            return View(user);
        }

        public ActionResult Delete(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
            }
            return RedirectToAction("Index");
        }
    }

}
