using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Core_02
{
    public class Program
    {
        //DotNet Framework ile EF projeleri yaparken sihirbaz yardýmýyla
        //Projemize EF ekleyebiliyorduk.
        //Ancak, Core projelerinde bu iþi sihirbaz yardýmýyla yapabileceðimiz bir yok YOK!!!
        //Bu iþi terminal ekranýnda komutlar yazarak gerçekleþtireceðiz.
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
