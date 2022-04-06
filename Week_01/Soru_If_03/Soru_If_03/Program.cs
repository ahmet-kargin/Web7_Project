using System;

namespace Soru_If_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan hangi işlemi yapmak istediğini
             * soran, ve aldığı cevaba göre Toplama, Çıkarma
             * Çarpma ya da Bölme işlemini yine kullanıcının
             * gireceği iki sayı arasında gerçekleştirip sonucu
             * ekrana aşağıdaki gibi yazan programı hazırlayınız.
             * Örnek:
             * Seçilen İşlem: Toplama
             * 
             * Toplama ===> 40 + 50 = 90
             */
            int sonuc=0;
            string islemAd="";
            Console.WriteLine("Topla        : +");
            Console.WriteLine("Çıkarma      : -");
            Console.WriteLine("Çarpma       : *");
            Console.WriteLine("Bölme        : /");
            Console.Write("İşlemi seçiniz   : ");
            string islemTuru = Console.ReadLine();
            Console.Write("Birinci Sayı     : ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayı      : ");
            int sayi2 = int.Parse(Console.ReadLine());
            
            if (islemTuru=="+")
            {
                sonuc = sayi1 + sayi2;
                islemAd = "Toplama";
            }
            else if(islemTuru=="-")
            {
                sonuc = sayi1 - sayi2;
                islemAd = "Çıkarma";
            }
            else if(islemTuru=="*")
            {
                sonuc = sayi1 * sayi2;
                islemAd = "Çarpma";
            }
            else if (islemTuru=="/")
            {
                sonuc = sayi1 + sayi2;
                islemAd = "Bölme";
            }
            else
            {
                Console.WriteLine("HATA!");
            }
            
            Console.WriteLine($"Seçilen İşlem: {islemAd}\n{islemAd} ===> {sayi1} {islemTuru} {sayi2} = {sonuc}");
            Console.WriteLine($@"Bugün
hava




çok


güzel");
            Console.ReadLine();
        }
    }
}
