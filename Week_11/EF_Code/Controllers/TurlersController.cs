using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EF_Code.Models;
namespace EF_Code.Controllers
{
    public class TurlersController : Controller
    {
        private readonly KutuphaneAksamContext _context;
        public TurlersController(KutuphaneAksamContext context)
        {
            _context=context;
        }
        //GET-Listeleme
        public IActionResult Index(){
            return View(_context.Turlers.ToList()); //List tipinde değerler gönderiliyor.
        }
        //GET-detay gösterme
        public IActionResult Details(int id){
            var tur= _context.Turlers.Find(id);
            return View(tur);
        }
        //GET-Düzeltme sayfası
        public IActionResult Edit(int id){
            var tur = _context.Turlers.Find(id);
            return View(tur);
        }
        //POST-düzeltme işlemi
        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id, TurAd")] Turler tur)
        {
            _context.Update(tur); //Bu satır context i güncelledi.
            _context.SaveChanges(); //Bu satır database i güncelledi.
            return RedirectToAction("Index");
            //return View(tur);
        }
        //DELETE işlemi
        public IActionResult Delete(int id)
        {
            var silinecekKitapTuru = _context.Turlers.Find(id);
            return View(silinecekKitapTuru);
        }
        [HttpPost,ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int id){
            var silinecekKitapTuru = _context.Turlers.Find(id);
            _context.Turlers.Remove(silinecekKitapTuru);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] //Post zaten kayıt işlemidir
        public IActionResult Create(Turler tur)
        {
            _context.Add(tur);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}