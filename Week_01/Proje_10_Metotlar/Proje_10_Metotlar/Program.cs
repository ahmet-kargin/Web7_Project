using System;

namespace Proje_10_Metotlar
{
    class Program
    {

        static void Main(string[] args)
        {
            //Parametre almayan ve geri değer döndürmeyen
            void Toplama()
            {
                int s1 = 10;
                int s2 = 20;
                Console.WriteLine(s1+s2);
            }
            //Parametre almayan ve geri değer döndürmeyen
            void GirisYap()
            {
                Console.Clear();
                Console.Write("Lütfen kullanıcı adını gir: ");
                string ad = Console.ReadLine();
            }
            //Parametre alan ve geri değer döndürmeyen
            void Merhaba(string ad, int yil)
            {
                Console.WriteLine($"Merhaba {ad}, hoşgeldin. Bu, {yil}.yılın.");
            }

            //int a = 15;

            //Geri değer döndüren ve parametre almayan
/*            int Kare()
            {
                return a * a;
            }*/

            int Kare2(int kenarUzunlugu)
            {
                return kenarUzunlugu * kenarUzunlugu;
            }

            int karesiniBul = Kare2(7);
            Console.WriteLine(karesiniBul);

            /*int karesi = Kare();*/






/*
            Merhaba("Engin",8);
            Merhaba("Büşra",9);
            Merhaba("Sezer",25);
            Merhaba("Gomis",12);
            Merhaba("Ali",78);*/


















            /*            Toplama();
                        Console.WriteLine("Hello World!");
                        Console.ReadLine();
                        GirisYap();
                        Console.WriteLine("Hello World!");
                        Toplama();
                        Toplama();
                        Console.ReadLine();
                        GirisYap();*/
            Console.ReadLine();
        }
    }
}
