using System;

namespace Proje_09_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int enBuyuk = 0;
            int sayi = 0;
            for (int i = 1; i <=3; i++)
            {
                Console.Write($"{i}.sayıyı gir: ");
                sayi = int.Parse(Console.ReadLine());
                if (sayi>enBuyuk)
                {
                    enBuyuk = sayi;
                }
            }

            Console.WriteLine($"En büyük sayı: {enBuyuk}");*/

            /*            int[] sayilar = { 4, 6, 9 };
                        Console.WriteLine(sayilar[1]);*/
            /*
                        Random rnd = new Random();
                        *//*            int rastgeleSayi = rnd.Next(1,100);
                                    Console.WriteLine(rastgeleSayi);*//*
                        //Diziye 10 adet rastgele değer atıyoruz:
                        int[] dizi = new int[10];
                        for (int i = 0; i < 10; i++)
                        {
                            dizi[i] = rnd.Next(1, 100);
                        }


                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine(dizi[i]);
                        }*/

            /*rastgele 5 değer oluşturalım.1-100 arası
             * Sonra sıralarını ters çevirin.
             * Ekranda iki halini de görelim
             */

            //FOR EACH
            /*            string[] kisiler =
                        {
                            "Elif",
                            "Ayşen",
                            "Umay",
                            "Begüm",
                            "Ceyda"
                        };
                        foreach (var kisi in kisiler)
                        {
                            Console.WriteLine(kisi);
                        }*/

            Random rnd = new Random();
            int sayi = rnd.Next(1, 100);
            int tahmin = 0;
            int puan = 50;
            Console.WriteLine(sayi);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}.Tahmininizi giriniz(1-100): ");
                tahmin = int.Parse(Console.ReadLine());
                if (tahmin == sayi)
                {
                    Console.WriteLine($"Tebrikler! Oyunu kazandın! Puanın: {puan}");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if(i!=5)
                {
                    if (tahmin > sayi)
                    {
                        Console.WriteLine("Daha küçük bir sayı gir.");
                    }
                    else
                    {
                        Console.WriteLine("Daha büyük bir sayı gir.");
                    }
                }
                puan -= 10;
            }
            Console.WriteLine("KAYBETTİN, PUAN KAZANAMADIN");
            Console.ReadLine();
        }
    }
}
