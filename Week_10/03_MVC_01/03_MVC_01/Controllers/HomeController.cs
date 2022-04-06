using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_MVC_01.Controllers
{
<<<<<<< HEAD
    //Tüm controller'lar Controller sınıfından miras alır.
    //Öyleyse bir requesti karşılayacak bir özellik kazanmasınıistiyorsak,
    //ilgigli class ı Controller sınıfından türetmeliyiz.
    public class HomeController : Controller
    {
        //Action Methd: Eğer bir metot bir Controller içinde ise ona
        //Action method diyeceğiz, hatta çoğu kez action deriz.

        //Bu action uygulamanın ana dizinine istek gönderildiğinde tetiklenecektir.
        public IActionResult Index()
        {
            //Eğer View metodu bu şekilde kullanılısa
            //(yani parantez içi boş bırakılırsa, parametresiz kullanılırsa)
            //içinde bulunduğu Action'ın adındaki View'ı arar. ve onu döndürür.
            return View();
        }
=======
    //Tüm controllerlar Controller sınıfından miras alırlar.
    //Öyleyse bir requesti karşılayacak bir özellik kazanmasını istiyorsak,
    //ilgili classı Controller sınıfından türetmeliyiz.
    public class HomeController : Controller
    {
        //Action Method: Eğer bir metot bir Controller içinde ise ona 
        //Action Method diyeceğiz, hatta çoğu kez Action deriz.

        //Bu action uygulamanın ana dizinine istek gönderildiğinde
        //tetiklenecektir.
        public IActionResult Index()
        {
            //Eğer View metodu bu şekilde kullanılırsa
            //(yani parantez içi boş bırakılırsa,parametresiz kullanılırsa)
            //içinde bulunduğu Action'ın adındaki View'ı arar. Ve onu döndürür.
            return View();
        }

        public void X()
        {

        }


>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
    }
}
