using Microsoft.AspNetCore.Mvc;
using mvc_10._01._2024.Models;
using System.Collections.Generic;
using System.Linq;

namespace mvc_10._01._2024.Controllers
{

    public class TasksController : Controller
    {
        private static List<Models.Task> _tasks = new List<Models.Task>();

        public ActionResult Index()
        {
            return View(_tasks);
        }

        public ActionResult Details(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Task task)
        {
            if (ModelState.IsValid)
            {
                task.Id = _tasks.Count + 1;
                _tasks.Add(task);
                return RedirectToAction("Index");
            }
            return View(task);
        }

        public ActionResult Edit(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        [HttpPost]
        public ActionResult Edit(int id, Models.Task task)
        {
            if (ModelState.IsValid)
            {
                var existingTask = _tasks.FirstOrDefault(t => t.Id == id);
                if (existingTask == null)
                {
                    return NotFound();
                }

                existingTask.Title = task.Title;
                existingTask.Description = task.Description;
                existingTask.IsCompleted = task.IsCompleted;
                existingTask.UserId = task.UserId;

                return RedirectToAction("Index");
            }
            return View(task);
        }

        public ActionResult Delete(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _tasks.Remove(task);
            }
            return RedirectToAction("Index");
        }
    }

}
