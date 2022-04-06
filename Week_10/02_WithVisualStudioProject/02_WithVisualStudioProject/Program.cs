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
        //Asl�nda t�m Asp.net core uygulamalar� birer console uygulamalar�d�r.
=======
        //Asl�nda t�m Asp.net core uygulamalar� birer console uygulamas�d�r.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
        //Do�al olarak uygulama �al��maya Program.cs dosyas� i�indeki
        //Main metodu ile ba�lar.
        public static void Main(string[] args)
        {
            //Buras� uygulamam�z�n ba�lang�� noktas�d�r.
            //T�m i�leyi� bu noktada ba�l�yor.
            //CreateHostBuilder metodu �a�r�larak sunucumuza dair
            //t�m �zellikler, konfig�rasyonlar belirleniyor ve sonu�
<<<<<<< HEAD
            //buraya d�nd�r�l�yor.D�nen sunucu bilgileri ile
            //uygulama �nce Build(derleme) sonra ise Run(�al��t�rma) ediliyor.
             CreateHostBuilder(args).Build().Run();
        }
        //CreateHostBuilder metodu sunucuyu aya�a kald�r�rken, bir tak�m konfigurasyonlara ihtiya� fuyar.
        //Bu konfigurasyonlar� startup class�ndan al�r ve kullan�r.
=======
            //buraya d�nd�r�l�yor.D�nen sunucu bilgileri ile 
            //uygulama �nce Build(derleme) sonra ise Run(�al��t�rma) ediliyor.
            CreateHostBuilder(args).Build().Run();
        }
        //CreateHostBuilder metodu sunucuyu aya�a kald�r�rken, bir tak�m
        //konfig�rasyonlara ihtiya� duyar. Bu konfig�rasyonlar� Startup 
        //class�ndan al�r ve kullan�r.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
<<<<<<< HEAD
                    //Default olarak olu�turulan bu yap�da,ba�lang�� konfigurasyonlar� Startup ad�ndaki
                    //classda yer al�yor.
=======
                    //Default olarak olu�turulan bu yap�da, ba�lang��
                    //konfig�rasyonlar� Startup ad�ndaki classta yer al�yor.
>>>>>>> d1139366e9d3780fc402e9aa5385c186a6f3c8b5
                    //Ancak bu isim mecburi bir isim de�ildir.
                    webBuilder.UseStartup<Startup>();
                });
    }
}
