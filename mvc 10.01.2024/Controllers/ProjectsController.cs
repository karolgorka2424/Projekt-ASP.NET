using Microsoft.AspNetCore.Mvc;
using mvc_10._01._2024.Models;
using System.Collections.Generic;
using System.Linq;

namespace mvc_10._01._2024.Controllers
{


    public class ProjectsController : Controller
    {
        private static List<Project> _projects = new List<Project>();

        public ActionResult Index()
        {
            return View(_projects);
        }

        public ActionResult Details(int id)
        {
            var project = _projects.FirstOrDefault(p => p.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Project project)
        {
            if (ModelState.IsValid)
            {
                project.Id = _projects.Count + 1;
                _projects.Add(project);
                return RedirectToAction("Index");
            }
            return View(project);
        }

        public ActionResult Edit(int id)
        {
            var project = _projects.FirstOrDefault(p => p.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        [HttpPost]
        public ActionResult Edit(int id, Project project)
        {
            if (ModelState.IsValid)
            {
                var existingProject = _projects.FirstOrDefault(p => p.Id == id);
                if (existingProject == null)
                {
                    return NotFound();
                }

                existingProject.Title = project.Title;
                existingProject.Description = project.Description;

                return RedirectToAction("Index");
            }
            return View(project);
        }

        public ActionResult Delete(int id)
        {
            var project = _projects.FirstOrDefault(p => p.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var project = _projects.FirstOrDefault(p => p.Id == id);
            if (project != null)
            {
                _projects.Remove(project);
            }
            return RedirectToAction("Index");
        }
    }

}
