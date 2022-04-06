using System;

namespace Proje_07_While
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            int sayac = 1;
                        while (sayac<=5)
                        {
                            Console.WriteLine($"Hello World!-{sayac}");
                            sayac++;
                        }
                        Console.WriteLine(sayac);*/
            /*
                        int sayac = 1;
                        int toplam = 0;
                        while (sayac<=10)
                        {
                            Console.WriteLine(sayac);
                            toplam += sayac;
                            sayac++;
                        }
                        Console.WriteLine($"Toplam: {toplam}");*/

            /*
             * Klavyeden "exit" yazana kadar 
             * Ekrana sürekli yine yeni yeniden Hello World
             * yazan programı hazırlayınız. (Yani, exit yazıp
             * enter tuşuna basınca program sona erecek.)
             */
            /*            string bisey="";
                        while (bisey!="exit")
                        {
                            Console.WriteLine("Hello World");
                            bisey = Console.ReadLine();
                            Console.Clear();
                        }*/

            /*            string bisey;
                        do
                        {
                            Console.WriteLine("Hello");
                            bisey = Console.ReadLine();
                            Console.Clear();
                        } while (bisey!="exit");*/

            /*Çalıştığında kullanıcıdan bir kullanıcı adı
             * ve bir şifre istesin.
             * Kullanıcı adı: admin, şifre: 123 olana kadar
             * giriş yapmaya devam ettirelim.
             * Doğru bilgiler girilmezse : GEÇERSİZ GİRİŞ
             * yazsın ve yeniden bilgileri istesin.
             * Doğru bilgiler girilirse: TEBRİKLER, GİRİŞ YAPTINIZ
             * diyerek programı bitirsin.
             */

            string userName = "admin";
            string pass = "123";
            string gUserName = "";
            string gPass = "";
            bool durum = false;

            do
            {
                if (durum)
                {
                    Console.Clear();
                    Console.WriteLine("Hatalı giriş.");
                    Console.ReadLine();
                    Console.Clear();
                }
                Console.Write("Kullanıcı adını gir: ");
                gUserName = Console.ReadLine();
                Console.Write("Şifreyi gir: ");
                gPass = Console.ReadLine();
                durum = true;

            } while (gUserName!=userName || gPass!=pass);
            Console.WriteLine("Aferin sana!");
            Console.ReadLine();
            //Console.ReadLine();
        }
    }
}
