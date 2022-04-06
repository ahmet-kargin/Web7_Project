using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_MVC_01
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
<<<<<<< HEAD
            //Bu service'i ekleyerek uygulamamýn MVC mimarisnde olacaðýný belirtmiþ olduk.
            //Dolayýsýyla bu uygulamaya gelen bir request karþýlanabilir haldedir.
            //Karþýlayacak olan þey, Controller'dýr.
            //Gelen requeste karþýlýk, döndüreceðimiz responce bir HTML sayfa olacaðý için
            //Views'i de kullanacaðýmýzý belirtmiþ olduk.
            //Model ise bir SERVÝCE DEÐÝLDÝR. Bu yüzden onu eklemek gibi bir iþlem yapmýyoruz.
=======
            //Bu service'i ekleyerek uygulamamýn MVC mimarisinde
            //olacaðýný belirtmiþ olduk. 
            //Dolayýsýyla bu uygulamaya gelen bir request karþýlanabilir haldedir.
            //Karþýlayacak olan þey, Controller'dýr. 
            //Gelen requeste karþýlýk, döndüreceðimiz response bir HTML sayfa
            //olacaðý için Views'i de kullanacaðýmzýý belirtmiþ olduk.
            //*Model ise bir SERVICE DEÐÝLDÝR! Bu yüzden burada onu eklemek
            //gibi bir iþlem yapmýyoruz.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
<<<<<<< HEAD

            //Gelen requestlerin rotasý bu middleware tarafýndan belirlenecektir.
            //Rotalama sistemi burada kullanýlmaya baþlar.
            
            app.UseRouting();
            //Bu yapý içerisindeki en kritik middlewarelerden birisi budur.,
            //Varýþ Noktasý.
            //Bir request geldiðinde onu anlamlandýracak ve gitmesi gereken yere yönlendirecek yapýdýr.
=======
            //Gelen requestlerin rotasý bu middleware tarafýndan
            //belirlenecektir.Rotalama sistemi burada kullanýlmaya baþlar.
            app.UseRouting();
            //Bu yapý içerisindeki en kritik middlewarelerden birisi budur:
            //endpoints!
            //Varýþ Noktasý!
            //Bir request geldiðinde onu anlamlandýracak ve gitmesi gereken
            //yere yönlendirecek yapýdýr.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //abc.com
<<<<<<< HEAD
=======
                //abc.com/product
                //abc.com/product/index
                //abc.com/product/getCategories
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
            });
        }
    }
}
