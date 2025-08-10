using CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ProductContext _context;

        public CategoriesController(ProductContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            IEnumerable<Category> lstcategories = _context.Categories.ToList();
            return View(lstcategories);
        }

        public IActionResult Details(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            return View(category);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category cat)
        {
            _context.Categories.Add(cat);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Category category = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(int id, Category cat)
        {
            var existingCategory = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            existingCategory.CategoryName = cat.CategoryName;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Category category = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Delete(int id, Category cat)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId==id);
            _context.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
