using _07_DersBlogSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_DersBlogSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var articles = new List<Article>
            {
                new Article {ID=1, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." ArticleButton="Go Somewhere"},
                new Article {ID=2, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." ArticleButton="Go Somewhere"},
                new Article {ID=3, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." ArticleButton="Go Somewhere"},
                new Article {ID=4, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." ArticleButton="Go Somewhere"},
                new Article {ID=5, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." ArticleButton="Go Somewhere"},
                new Article {ID=6, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." ArticleButton="Go Somewhere"},
                new Article {ID=7, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." ArticleButton="Go Somewhere"},
                new Article {ID=8, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." ArticleButton="Go Somewhere"},
                new Article {ID=9, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." ArticleButton="Go Somewhere"},
            };
            return View(articles);
        }
    }
}
