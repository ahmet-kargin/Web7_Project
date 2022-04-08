using _07_DersBlogSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_DersBlogSite.Controllers
{
    public class LessonController : Controller
    {
        public IActionResult Index()
        {
            var lessons = new List<Lesson>
            {
                new Lesson {ID=1, LessonName="HTML", Category="FrontEnd"},
                new Lesson {ID=2, LessonName="CSS", Category="FrontEnd"},
                new Lesson {ID=3, LessonName="BootStarp", Category="FrontEnd"},
                new Lesson {ID=4, LessonName="Java Script", Category="FrontEnd"},
                new Lesson {ID=5, LessonName="Jquery", Category="FrontEnd"},
                new Lesson {ID=6, LessonName="React", Category="FrontEnd"},
                new Lesson {ID=7, LessonName="C#", Category="FrontEnd"},
                new Lesson {ID=8, LessonName="PHP", Category="FrontEnd"},
            };
            return View(lessons);
        }
    }
}
