using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Controllers
{
    public class MiniShopController : Controller
    {
        private IProductService _productService;
        public MiniShopController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(string category) 
        {
            return View(_productService.GetProductsByCategory(category));
        }
        public IActionResult Search(string searchString)
        {
            return View(_productService.GetSearchResult(searchString)); //Method yazılıp tekrar gelinecek buraya
        }
    }
}
