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
            _context = context;
        }
        //GET listeleme
        public IActionResult Index()
        {
            return View(_context.Yayinevleris.ToList());
        }
        public IActionResult Details(int id)
        {
            var yayinevi = _context.Yayinevleris.Find(id);
            return View(yayinevi);
        }
    }
}