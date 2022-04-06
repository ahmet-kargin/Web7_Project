using System;

namespace Proje_11_Metotlar_Örnek2
{
    class Program
    {
        static int Topla(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Topla(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        static int EnBuyuk(int[] sayilar)
        {
            int enb = 0;
            foreach (var sayi in sayilar)
            {
                if (sayi>=enb)
                {
                    enb = sayi;
                }
            }
            return enb;
        }

        static int BuyukKucuk(int[] sayilar,bool tur)
        {
            int sonuc = sayilar[0];
            foreach (var sayi in sayilar)
            {
                if (tur)
                {
                    if (sayi >= sonuc)
                    {
                        sonuc = sayi;
                    }
                }
                else
                {
                    if (sayi <= sonuc)
                    {
                        sonuc = sayi;
                    }
                }
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            int[] sayilar = { 7, 450, 9887, 960, 65, 1487, 19 };
            int Buyuk = EnBuyuk(sayilar);
            Console.WriteLine(Buyuk);
            Console.ReadLine();

            Console.Clear();
            Buyuk = BuyukKucuk(sayilar, true);
            Console.WriteLine(Buyuk);
            Buyuk = BuyukKucuk(sayilar, false);
            Console.WriteLine(Buyuk);
            Console.ReadLine();














/*            Console.WriteLine(Topla(5, 6));
            Console.ReadLine();
            Console.WriteLine(Topla(6,7,4));*/
        }
    }
}
