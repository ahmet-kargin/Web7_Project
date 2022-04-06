using System;

namespace Proje_06_If
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Engin";
            string gAd = Console.ReadLine();
            if (ad==gAd)
            {
                //True ise yapılacaklar
                Console.WriteLine($"Hoş geldin {gAd}");
            }
            else if("Ahmet"==gAd)
            {
                Console.WriteLine($"{gAd}, sen önce parola için IT'ye başvur.");
            }
            else
            {
                //False ise yapılacaklar
                Console.WriteLine($"{gAd}, sen geçersiz bir kullanıcısın. Kusura bakma.");
            }
            Console.ReadLine();
        }
    }
}
