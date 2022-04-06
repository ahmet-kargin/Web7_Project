using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_MVC_01.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetProducts()
        {
<<<<<<< HEAD
            return View("UrunleriGetir");
=======
            int a = 5;
            if (a<10)
            {
                return View("UrunleriGetir");
            }
            else
            {
                return View("Index");
            }
            
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
        }
    }
}
