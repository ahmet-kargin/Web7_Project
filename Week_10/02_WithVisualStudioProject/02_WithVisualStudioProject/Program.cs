using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_WithVisualStudioProject
{
    public class Program
    {
<<<<<<< HEAD
        //Aslýnda tüm Asp.net core uygulamalarý birer console uygulamalarýdýr.
=======
        //Aslýnda tüm Asp.net core uygulamalarý birer console uygulamasýdýr.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
        //Doðal olarak uygulama çalýþmaya Program.cs dosyasý içindeki
        //Main metodu ile baþlar.
        public static void Main(string[] args)
        {
            //Burasý uygulamamýzýn baþlangýç noktasýdýr.
            //Tüm iþleyiþ bu noktada baþlýyor.
            //CreateHostBuilder metodu çaðrýlarak sunucumuza dair
            //tüm özellikler, konfigürasyonlar belirleniyor ve sonuç
<<<<<<< HEAD
            //buraya döndürülüyor.Dönen sunucu bilgileri ile
            //uygulama önce Build(derleme) sonra ise Run(çalýþtýrma) ediliyor.
             CreateHostBuilder(args).Build().Run();
        }
        //CreateHostBuilder metodu sunucuyu ayaða kaldýrýrken, bir takým konfigurasyonlara ihtiyaç fuyar.
        //Bu konfigurasyonlarý startup classýndan alýr ve kullanýr.
=======
            //buraya döndürülüyor.Dönen sunucu bilgileri ile 
            //uygulama önce Build(derleme) sonra ise Run(çalýþtýrma) ediliyor.
            CreateHostBuilder(args).Build().Run();
        }
        //CreateHostBuilder metodu sunucuyu ayaða kaldýrýrken, bir takým
        //konfigürasyonlara ihtiyaç duyar. Bu konfigürasyonlarý Startup 
        //classýndan alýr ve kullanýr.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
<<<<<<< HEAD
                    //Default olarak oluþturulan bu yapýda,baþlangýç konfigurasyonlarý Startup adýndaki
                    //classda yer alýyor.
=======
                    //Default olarak oluþturulan bu yapýda, baþlangýç
                    //konfigürasyonlarý Startup adýndaki classta yer alýyor.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
                    //Ancak bu isim mecburi bir isim deðildir.
                    webBuilder.UseStartup<Startup>();
                });
    }
}
