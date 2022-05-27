using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShopApp.WebUI.Identity;
using MiniShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            LoginModel loginModel = new LoginModel();
            return View(loginModel);
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            //Daha sonra burayı dolduracağız.
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                FirstName = model.FirstName,
                LastName=model.LastName,
                UserName=model.UserName,
                Email=model.EMail
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)//Başarılı bir şekilde Create gerçekleştiyse
            {
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user); //Benzersiz bir yapı sağlar
                var url = Url.Action("ConfirmEmail", "Account", new
                {//Account controllera git oradan confirmed yap
                    userId = user.Id,
                    token = code
                });
            }
            return View();
        }
    }
}
