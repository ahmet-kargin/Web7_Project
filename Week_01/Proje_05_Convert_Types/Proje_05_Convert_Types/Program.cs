using System;

namespace Proje_05_Convert_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ad;
            //Console.Write("Adınızı giriniz: ");
            //ad = Console.ReadLine();
            //int yas;
            //Console.Write("Yaşınızı giriniz: ");
            //yas = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Merhaba {ad}, sen {yas} yaşındasın.");

            //int sNot = Convert.ToInt32(Console.ReadLine());
            //double gNot = sNot * 17 / 100;
            //Console.WriteLine(gNot);

            //byte sayi = 96;
            //int sayi2 = sayi;

            ushort sayi = 400;
            byte sayi2 = (byte)sayi;
            Console.WriteLine(sayi2);
            Console.ReadLine();
        }
    }
}
