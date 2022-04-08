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
                new Article {ID=1, ArticleHeader="CSS Flexbox Kullanımı",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=2, ArticleHeader="HTML Semantik Etiketler",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=3, ArticleHeader="C# Değişkenler",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=4, ArticleHeader="PHP'de MVC Mimarisi",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=5, ArticleHeader="JavaScript ile Açılır Menü",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=6, ArticleHeader="Responsive Menü Yapımı",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=7, ArticleHeader="C# ile Konsol Projeleri",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=8, ArticleHeader="C#'ta Döngüler",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=9, ArticleHeader="PHP ile Sunucular",ArticleText="With supporting text below as a natural lead-in to additional content."},
            };
            //Model bazlı veri taşıma yöntemi
            //return View(articles);

            //ViewBag ile veri taşıma
            //ViewBag.Articles = articles;

            //ViewData ile veri taşıma
            //ViewData["makaleler"] = articles;

            //TempData ile veri taşıma
            TempData["articles"] = articles;
            return View();
        }
        public IActionResult GetArticle()
        {
            var articles = new List<Article>
            {
                new Article {ID=1, ArticleHeader="CSS Flexbox Kullanımı",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=2, ArticleHeader="HTML Semantik Etiketler",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=3, ArticleHeader="C# Değişkenler",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=4, ArticleHeader="PHP'de MVC Mimarisi",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=5, ArticleHeader="JavaScript ile Açılır Menü",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=6, ArticleHeader="Responsive Menü Yapımı",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=7, ArticleHeader="C# ile Konsol Projeleri",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=8, ArticleHeader="C#'ta Döngüler",ArticleText="With supporting text below as a natural lead-in to additional content."},
                new Article {ID=9, ArticleHeader="PHP ile Sunucular",ArticleText="With supporting text below as a natural lead-in to additional content."},
            };
            int id = Convert.ToInt32(ControllerContext.RouteData.Values["ID"]);

            ViewBag.ID = articles[id - 1];
            return View();
            //HTML Helper ve TAG Helper konularını araştırın.
        }
    }
}