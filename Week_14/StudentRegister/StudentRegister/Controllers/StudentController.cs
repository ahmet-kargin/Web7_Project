using Microsoft.AspNetCore.Mvc;
using StudentRegister.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegister.Controllers
{
    public class StudentController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
    }
}
