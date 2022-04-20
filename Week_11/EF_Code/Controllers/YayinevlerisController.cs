using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EF_Code.Models;

namespace EF_Code.Controllers
{
    public class YayinevlerisController : Controller
    {
        private readonly KutuphaneAksamContext _context;
        public YayinevlerisController(KutuphaneAksamContext context)
        {
            _context=context;
        }
        //GET-Listeleme
        public IActionResult Index(){
            return View(_context.Yayinevleris.ToList()); //List tipinde değerler gönderiliyor.
        }
        //GET-detay gösterme
        public IActionResult Details(int id){
            var yayinevleri= _context.Yayinevleris.Find(id);
            return View(yayinevleri);
        }
        //GET-Düzeltme sayfası
        public IActionResult Edit(int id){
            var yayinevleri = _context.Yayinevleris.Find(id);
            return View(yayinevleri);
        }
        //POST-düzeltme işlemi
        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id, Ad")] Yayinevleri yayinevleri)
        {
            _context.Update(yayinevleri); //Bu satır context i güncelledi.
            _context.SaveChanges(); //Bu satır database i güncelledi.
            return RedirectToAction("Index");
            //return View(tur);
        }
        //DELETE işlemi
        public IActionResult Delete(int id)
        {
            var silinecekYayinevi = _context.Yayinevleris.Find(id);
            return View(silinecekYayinevi);
        }
        [HttpPost,ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int id){
            var silinecekYayinevi = _context.Yayinevleris.Find(id);
            _context.Yayinevleris.Remove(silinecekYayinevi);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] //Post zaten kayıt işlemidir
        public IActionResult Create(Yayinevleri yayınevi)
        {
            _context.Add(yayınevi);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}