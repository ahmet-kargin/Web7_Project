using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShopApp.WebUI.EmailServices;
using MiniShopApp.WebUI.Identity;
using MiniShopApp.WebUI.Models;
using Newtonsoft.Json;
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
        private IEmailSender _emailSender;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _emailSender = emailSender;
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
        public async Task<IActionResult>  Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user==null)
            {
                ModelState.AddModelError("","Böyle bir kullanıcı bulunamadı.");
                return View(model);
            }
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Hesabınız onaylanmamış Lütfen mail hesabınıza gelen onay linkine tık yaparak onaylayınız.");
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            CreateMessage("Şifreniz Hatalı", "danger");
            return View(model);
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
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user); //Benzersiz bir yapı sağlar. Jeston görevi görür epğer başarılıysa erişim sağlar.
                var url = Url.Action("ConfirmEmail", "Account", new
                {//Account controllera git oradan confirmed yap
                    userId = user.Id,
                    token = code
                });
                //email gönderme işlemi
                await _emailSender.SendEmailAsync(model.EMail, "MiniShopApp Confirm Account",
                    $"Lütfen email adresininzi onaylamak için <a href:'https://localhost:5001{url}'>tıklayınız!</a>");
                CreateMessage("Kayıt işleminizi tamamlamak içn mailinize gönderilen onaylama linkine tıklayınız!",
                    "warning");
                return RedirectToAction("Login", "Account");
            }
            return View();
        }

        public async Task<IActionResult>  ConfirmEmail(string userId, string token)
        {
            if (userId == null || token ==null)
            {
                CreateMessage("Bir sorun oluştur", "warning");
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user!=null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    CreateMessage("Hesabınız onaylanmıştır!", "success");
                }
                return View();
            }

            CreateMessage("Hesabınız onaylanmamıştır! Lütfen daha sonra tekrar deneyiniz!", "danger");
            return View();
        }
        private void CreateMessage(string message, string alertType)
        {
            var msg = new AlertMessage()
            {
                Message = message,
                AlertType = alertType
            };
            TempData["Message"] = JsonConvert.SerializeObject(msg);
        }
    }
}
