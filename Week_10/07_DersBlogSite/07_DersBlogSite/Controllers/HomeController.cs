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
                new Article {ID=1, ArticleTitle="CSS Flexbox kullanımı", ArticleContent="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=2, ArticleTitle="HTML Semantik Etikrtlrt", ArticleContent="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=3, ArticleTitle="C# Etiketler", ArticleContent="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=4, ArticleTitle="Jquery", ArticleContent="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=5, ArticleTitle="BootStarp", ArticleContent="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=6, ArticleTitle="PHP", ArticleContent="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=7, ArticleTitle="React", ArticleContent="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=8, ArticleTitle="PHYTON", ArticleContent="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=9, ArticleTitle="JAVA", ArticleContent="With supporting text below as a natural lead-in to additional content."}
            };
            //Model bazlı veri taşıma yöntemi
            //return View(articles);

            //ViewbAG ile taşıma dinamik yapı ile taşır
            //ViewBag.Articles = articles;

            //ViewData ile Taşıma  objesc yapı ile taşır
            //ViewData["makaleler"] = articles;

            //TempData ile veri taşıma cooky ile taşır.
            TempData["articles"] = articles;
            return View();
        }
    }
}
