using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentRegister.Models.Context;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegister.Controllers
{
    public class HomeController : Controller
    {
        private readonly LessonAssignmentContext _context;
        public HomeController(LessonAssignmentContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }
        
        
    }
}
