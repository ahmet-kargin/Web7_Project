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
            List<Article> articles = new List<Article>
            {
                new Article {ID=1, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." , ArticleButton="Go Somewhere"},
                new Article {ID=2, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." , ArticleButton="Go Somewhere"},
                new Article {ID=3, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." , ArticleButton="Go Somewhere"},
                new Article {ID=4, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." , ArticleButton="Go Somewhere"},
                new Article {ID=5, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." , ArticleButton="Go Somewhere"},
                new Article {ID=6, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." , ArticleButton="Go Somewhere"},
                new Article {ID=7, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." , ArticleButton="Go Somewhere"},
                new Article {ID=8, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." , ArticleButton="Go Somewhere"},
                new Article {ID=9, ArticleTitle="Special title treatment", ArticleContent="With supporting text below as a natural lead-in to additional content." , ArticleButton="Go Somewhere"},
            };
            //TempData["articles"] = articles;
            return View(articles);
        }

        public IActionResult Display(int id)
        {
            var articles = new List<Article>
            {
                new Article {ID=1, ArticleTitle="Special title treatment1", ArticleContent="With supporting text below as a natural lead-in to additional content.1" , ArticleButton="Go Somewhere"},
                new Article {ID=2, ArticleTitle="Special title treatment2", ArticleContent="With supporting text below as a natural lead-in to additional content.2" , ArticleButton="Go Somewhere"},
                new Article {ID=3, ArticleTitle="Special title treatment3", ArticleContent="With supporting text below as a natural lead-in to additional content.3" , ArticleButton="Go Somewhere"},
                new Article {ID=4, ArticleTitle="Special title treatment4", ArticleContent="With supporting text below as a natural lead-in to additional content.4" , ArticleButton="Go Somewhere"},
                new Article {ID=5, ArticleTitle="Special title treatment5", ArticleContent="With supporting text below as a natural lead-in to additional content.5" , ArticleButton="Go Somewhere"},
                new Article {ID=6, ArticleTitle="Special title treatment6", ArticleContent="With supporting text below as a natural lead-in to additional content.6" , ArticleButton="Go Somewhere"},
                new Article {ID=7, ArticleTitle="Special title treatment7", ArticleContent="With supporting text below as a natural lead-in to additional content.7" , ArticleButton="Go Somewhere"},
                new Article {ID=8, ArticleTitle="Special title treatment8", ArticleContent="With supporting text below as a natural lead-in to additional content.8" , ArticleButton="Go Somewhere"},
                new Article {ID=9, ArticleTitle="Special title treatment9", ArticleContent="With supporting text below as a natural lead-in to additional content.9" , ArticleButton="Go Somewhere"},
            };

            Article result = articles.Where(x => x.ID == id).FirstOrDefault();
            return View(result);
        }
    }
}
