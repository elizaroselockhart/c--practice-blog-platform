using BlogPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
    public class PostController : Controller
    {
        public BlogContext db;
        public PostController(BlogContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.Posts.ToList());
        }

        public IEnumerable<Post> AllPosts()
        {
            return db.Posts.ToList();
        }

        public IActionResult Details(int id)
        {
            return View(db.Posts.Where(r => r.Id == id).FirstOrDefault());
        }

        public IActionResult Create()
        {
            ViewBag.Categories = db.Categories.ToList();
            return View(new Post());
        }
        [HttpPost]
        public IActionResult Create(Post newPost)
        {
            db.Posts.Add(newPost);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ViewResult Edit(int id)
        {
            ViewBag.Categories = db.Categories.ToList();
            var post = db.Posts.Where(r => r.Id == id).FirstOrDefault();
            return View(post);
        }
        [HttpPost]
        public IActionResult Edit(Post editPost)
        {
            db.Update(editPost);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var post = db.Posts.Where(r => r.Id == id).FirstOrDefault();
            db.Posts.Remove(post);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
