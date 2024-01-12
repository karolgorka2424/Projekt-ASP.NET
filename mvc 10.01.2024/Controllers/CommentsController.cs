using Microsoft.AspNetCore.Mvc;
using mvc_10._01._2024.Models;
using System.Linq;
using System.Collections.Generic;

namespace mvc_10._01._2024.Controllers
{
    public class CommentsController : Controller
    {
        private static List<Comment> _comments = new List<Comment>();

        public ActionResult Index()
        {
            return View(_comments);
        }

        public ActionResult Details(int id)
        {
            var comment = _comments.FirstOrDefault(c => c.Id == id);
            if (comment == null)
            {
                return NotFound();
            }
            return View(comment);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                comment.Id = _comments.Count + 1;
                _comments.Add(comment);
                return RedirectToAction("Index");
            }
            return View(comment);
        }

        public ActionResult Edit(int id)
        {
            var comment = _comments.FirstOrDefault(c => c.Id == id);
            if (comment == null)
            {
                return NotFound();
            }
            return View(comment);
        }

        [HttpPost]
        public ActionResult Edit(int id, Comment comment)
        {
            if (ModelState.IsValid)
            {
                var existingComment = _comments.FirstOrDefault(c => c.Id == id);
                if (existingComment == null)
                {
                    return NotFound();
                }

                existingComment.Content = comment.Content;
                existingComment.TaskId = comment.TaskId;
                existingComment.UserId = comment.UserId;

                return RedirectToAction("Index");
            }
            return View(comment);
        }

        public ActionResult Delete(int id)
        {
            var comment = _comments.FirstOrDefault(c => c.Id == id);
            if (comment == null)
            {
                return NotFound();
            }
            return View(comment);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var comment = _comments.FirstOrDefault(c => c.Id == id);
            if (comment != null)
            {
                _comments.Remove(comment);
            }
            return RedirectToAction("Index");
        }
    }
}
