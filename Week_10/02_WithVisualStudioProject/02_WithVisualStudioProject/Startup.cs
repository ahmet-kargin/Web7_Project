using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_WithVisualStudioProject
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
<<<<<<< HEAD
            //Uygulamada kullanýlacak olan service'lerin eklendiði yada bildirildiði,
            //ayarlandýðý yerdir burasý. Service modil, kütüphane gibi düþünülebilir.
=======
            //Uygulamada kullanýlacak olan service'lerin eklendiði, bildirildiði,
            //ayarlandýðý yerdir. Service modül, kütüphane gibi düþünülebilir.
            //Ayrýca ele alacaðýz.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
<<<<<<< HEAD
            //Bu metod uygulamada kullanýlacak olan ara katman(ara yazýlým)larýn
            //bildirildiði ve ayarlarýn yapýldýðý yerdir.Sýkça Middleware olarak anýlýr.
=======
            //Bu metot uygulamada kullanýlacak olan ara katman(ara yazýlým)larýn
            //bildirildiði ve ayarlarýnýn yapýldýðý yerdir. Sýkça MiddleWare olarak
            //anýlýr, anýlacaktýr.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
<<<<<<< HEAD
            //Bu Middleware routing özelliklerini kullanacaðýmýzý belirtir.
=======
            //Bu middleware routing özelliklerini kullanacaðýmýzý belirtir.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
<<<<<<< HEAD
                //Endpoints uygulamaya gelen isteklerin varýþ noktasýný ifade eden þablon yapýsýdýr.
=======
                //endpoints uygulamaya gelen isteklerin varýþ noktasýný
                //ifade eden þablon yapýsýdýr.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
