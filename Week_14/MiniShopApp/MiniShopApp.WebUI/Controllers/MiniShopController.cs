using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using MiniShopApp.WebUI.Models;
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
        public IActionResult List(string category, int page=1) 
        {
            const int pageSize = 3;
            int totalItems = _productService.GetCountByCategory(category);
            var productListViewModel = new ProductListViewModel()
            {
                PageInfo = new PageInfo
                {
                    TotalItems=totalItems,
                    CurrentPage=page,
                    ItemsPerPage= pageSize,
                    CurrentyCategory=category
                },
                Products = _productService.GetProductsByCategory(category,page,pageSize)
            };

            return View(productListViewModel);
        }
        public IActionResult Search(string searchString)
        {
            return View(_productService.GetSearchResult(searchString)); //Method yazılıp tekrar gelinecek buraya
        }
    }
}
