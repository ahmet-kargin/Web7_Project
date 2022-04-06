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
            //Uygulamada kullan�lacak olan service'lerin eklendi�i yada bildirildi�i,
            //ayarland��� yerdir buras�. Service modil, k�t�phane gibi d���n�lebilir.
=======
            //Uygulamada kullan�lacak olan service'lerin eklendi�i, bildirildi�i,
            //ayarland��� yerdir. Service mod�l, k�t�phane gibi d���n�lebilir.
            //Ayr�ca ele alaca��z.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
<<<<<<< HEAD
            //Bu metod uygulamada kullan�lacak olan ara katman(ara yaz�l�m)lar�n
            //bildirildi�i ve ayarlar�n yap�ld��� yerdir.S�k�a Middleware olarak an�l�r.
=======
            //Bu metot uygulamada kullan�lacak olan ara katman(ara yaz�l�m)lar�n
            //bildirildi�i ve ayarlar�n�n yap�ld��� yerdir. S�k�a MiddleWare olarak
            //an�l�r, an�lacakt�r.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
<<<<<<< HEAD
            //Bu Middleware routing �zelliklerini kullanaca��m�z� belirtir.
=======
            //Bu middleware routing �zelliklerini kullanaca��m�z� belirtir.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
<<<<<<< HEAD
                //Endpoints uygulamaya gelen isteklerin var�� noktas�n� ifade eden �ablon yap�s�d�r.
=======
                //endpoints uygulamaya gelen isteklerin var�� noktas�n�
                //ifade eden �ablon yap�s�d�r.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
