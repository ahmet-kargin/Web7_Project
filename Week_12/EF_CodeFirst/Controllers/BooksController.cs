using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EF_CodeFirst.Controllers
{
    public class BooksController : Controller
    {
        private readonly LibraryContext _context;
        public BooksController(LibraryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var books = _context.Books
            .Where(x=>x.IsDeleted==false).ToList();
            return View(books);
        }
        public IActionResult Details(int id){
            var book = _context.Books.Find(id);
            return View(book);
        }
        public IActionResult Edit(int id){
            var book = _context.Books.Find(id);

            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Book book){
            _context.Books.Update(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
         public IActionResult GetDeleteBooks()
        {
            var books = _context.Books
            .Where(x=>x.IsDeleted==true).ToList();
            return View("Index",books);
        }
        public IActionResult Delete(int id)
        {
            var book = _context.Books.Find(id);
            return View(book);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = _context.Books.Find(id);
            book.IsDeleted=true;
            _context.Books.Update(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Create(){
            ViewData["CategoryId"]= new SelectList(_context.Books.)
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            _context.Add(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}