using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models.Context;
using EF_CodeFirst.Models.Entities;
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
            return View(_context.Categories.ToList());
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
        public IActionResult Edit(int id, [Bind("CategoryId, CategoryName")] Category category){
            _context.Update(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var deleteCategory = _context.Categories.Find(id);
            return View(deleteCategory);
        }
        [HttpPost,ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int id)
        {
            var deleteCategory = _context.Categories.Find(id);
            _context.Categories.Remove(deleteCategory);
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