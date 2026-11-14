using GameJordan.Data;
using GameJordan.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameJordan.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var category = _context.Categories.ToList();
            return View("Index",category);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }
        public IActionResult Details(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }

        public IActionResult Delete(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }
    }
}
