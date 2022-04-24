using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;


namespace EF_CodeFirst.Controllers
{

    public class AuthorsController : Controller
    {

//private member
        private readonly LibraryContext _context;
        //ctor
        public AuthorsController(LibraryContext context)
        {
            _context = context;
        }
//methods
        // public IActionResult Index(){
        //     var authors = _context.Authors.ToList();
        //     return View(authors);
        // }
        public IActionResult Index()
        {
            var authors = _context.Authors
            .Where(x=>x.IsDeleted==false).ToList();
            return View(authors);
        }

       public IActionResult Details(int id){
           var author =_context.Authors.Find(id);
           return View(author);
       }
       public IActionResult Edit(int id){
       var author =_context.Authors.Find(id);
       return View(author);
       }

       [HttpPost]
       public IActionResult Edit(Author author){
           _context.Authors.Update(author);
           _context.SaveChanges();
           return RedirectToAction("Index");
       }
       public IActionResult GetDeleteAuthors(){
           var authors = _context.Authors
           .Where(x=>x.IsDeleted==true).ToList();
           return View("Index",authors);
       }
       public IActionResult Delete(int id){
           var author =_context.Authors.Find(id);
           return View(author);
       }
       [HttpPost,ActionName("Delete")]
       public IActionResult DeleteConfirmed(int id){
           var author = _context.Authors.Find(id);
           author.IsDeleted=true;
           _context.Authors.Update(author);
           _context.SaveChanges();
           return RedirectToAction("Index");
       }
       public IActionResult Create(){
           return View();
       }
       [HttpPost]
       public IActionResult Create(Author author){
           _context.Add(author);
           _context.SaveChanges();
           return RedirectToAction("Index");
       }
    }
}