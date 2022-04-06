using System;

namespace Soru_02_If
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bir mağazadan alınan iki ürünün tutarları toplamı
             * 200 liranın üzerindeyse;
             * 2.ürüne %35 indirim uygulanmaktadır.
             * Ayrıca, tutar toplamı 250 liranın üzerinde ise
             * (tutar toplamının indirim uygulanmış hali)
             * her alışverişte alınan 25 TL kargo bedeli 
             * alınmamaktadır.
             * Bu duruma göre;
             * İki ürünün fiyatlarının girilmesini sağlayan
             * ve ödenecek toplam tutarı hesaplayıp ekrana
             * Ayrı ayrı her ürünün fiyatlarıyla birlikte
             * 1) Genel tutar
             * 2) İndirim uygulanmışsa indirimli tutar
             * 3) kargo bedeli
             * 4) Ödenecek en son toplamı yazdıracak programı
             * hazırlayınız.*/
            byte kargo = 25;
            double indirimliTutar=0;
            Console.Write("Ürün 1 Fiyatını Giriniz: ");
            double fiyat1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ürün 2 Fiyatını Giriniz: ");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());
            double genelTutar = fiyat1 + fiyat2;
            if (genelTutar>=200)
            {
                indirimliTutar = genelTutar - fiyat2 * 0.35;
            }
            else
            {
                indirimliTutar = genelTutar;
            }
            if (indirimliTutar>=250)
            {
                kargo = 0;
            }
            double odenecekTutar = indirimliTutar + kargo;
            Console.WriteLine($"Fiyat1: {fiyat1} , Fiyat2: {fiyat2} , Genel Tutar: {genelTutar} , İndirimli Tutar: {indirimliTutar} , Ödenece Tutar: {odenecekTutar}");
            Console.ReadLine();

            //Github hesabımızı bağladık.
        }
    }
}
