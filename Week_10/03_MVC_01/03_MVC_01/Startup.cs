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
            //Bu service'i ekleyerek uygulamam�n MVC mimarisnde olaca��n� belirtmi� olduk.
            //Dolay�s�yla bu uygulamaya gelen bir request kar��lanabilir haldedir.
            //Kar��layacak olan �ey, Controller'd�r.
            //Gelen requeste kar��l�k, d�nd�rece�imiz responce bir HTML sayfa olaca�� i�in
            //Views'i de kullanaca��m�z� belirtmi� olduk.
            //Model ise bir SERV�CE DE��LD�R. Bu y�zden onu eklemek gibi bir i�lem yapm�yoruz.
=======
            //Bu service'i ekleyerek uygulamam�n MVC mimarisinde
            //olaca��n� belirtmi� olduk. 
            //Dolay�s�yla bu uygulamaya gelen bir request kar��lanabilir haldedir.
            //Kar��layacak olan �ey, Controller'd�r. 
            //Gelen requeste kar��l�k, d�nd�rece�imiz response bir HTML sayfa
            //olaca�� i�in Views'i de kullanaca��mz�� belirtmi� olduk.
            //*Model ise bir SERVICE DE��LD�R! Bu y�zden burada onu eklemek
            //gibi bir i�lem yapm�yoruz.
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

            //Gelen requestlerin rotas� bu middleware taraf�ndan belirlenecektir.
            //Rotalama sistemi burada kullan�lmaya ba�lar.
            
            app.UseRouting();
            //Bu yap� i�erisindeki en kritik middlewarelerden birisi budur.,
            //Var�� Noktas�.
            //Bir request geldi�inde onu anlamland�racak ve gitmesi gereken yere y�nlendirecek yap�d�r.
=======
            //Gelen requestlerin rotas� bu middleware taraf�ndan
            //belirlenecektir.Rotalama sistemi burada kullan�lmaya ba�lar.
            app.UseRouting();
            //Bu yap� i�erisindeki en kritik middlewarelerden birisi budur:
            //endpoints!
            //Var�� Noktas�!
            //Bir request geldi�inde onu anlamland�racak ve gitmesi gereken
            //yere y�nlendirecek yap�d�r.
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
