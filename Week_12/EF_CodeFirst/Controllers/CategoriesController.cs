using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    public class CategoriesController : Controller
    {
        private readonly LibraryContext _context;
        public CategoriesController(LibraryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories
            .Where(x=>x.IsDeleted==false).ToList();
            return View(categories);
        }
        public IActionResult Details(int id){
            var category = _context.Categories.Find(id);
            return View(category);
        }
        public IActionResult Edit(int id){
            var category = _context.Categories.Find(id);

            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category category){
            _context.Categories.Update(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
         public IActionResult GetDeleteCategories()
        {
            var categories = _context.Categories
            .Where(x=>x.IsDeleted==true).ToList();
            return View("Index",categories);
        }
        public IActionResult Delete(int id)
        {
            var deleteCategory = _context.Categories.Find(id);
            return View(deleteCategory);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var deleteCategory = _context.Categories.Find(id);
            deleteCategory.IsDeleted=true;
            _context.Categories.Update(deleteCategory);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}