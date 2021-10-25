using BlogPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
    public class CategoryController : Controller
    {
        public BlogContext db;
        public CategoryController(BlogContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IEnumerable<Category> AllCategories()
        {
            return db.Categories.ToList();
        }

        public IActionResult Details(int id)
        {
            return View(db.Categories.Where(r => r.Id == id).FirstOrDefault());
        }
    }
}
