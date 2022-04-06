using System;

namespace Sayi_Tahmin_Oyunu_Metotla
{
    class Program
    {
        static int i = 1;
        static bool tekrar = false;
        static int SayiUret(Random rnd)
        {
            return rnd.Next(1, 100);
        }
        static int TahminGir(int i)
        {
            Console.Write($"{i}.tahmininizi giriniz: ");
            return int.Parse(Console.ReadLine());
        }

        static void Win(int puan)
        {
            Console.WriteLine($"Tebrikler, kazandınız!\nPuanınız: {puan}");
            tekrar = Tekrar();
        }

        static void Loss()
        {
            Console.WriteLine("Üzgünüm, kaybettiniz!\nPuanınız yok.");
            i = 0;
            tekrar = Tekrar();
        }

        static bool Tekrar()
        {

            Console.Write("Tekrar oynamak ister misiniz?(E/H): ");
            string cevap= Console.ReadLine();
            if (cevap=="e" || cevap=="E")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string Kontrol(int tahmin, int hedef, int i)
        {
            if (i == 5)
            {
                Loss();
            }
            if (tahmin > hedef)
            {
                return "Daha küçük bir sayı gir.";
            }
            else
            {
                return "Daha büyük bir sayı gir";
            }
        }

        static void Oyun()
        {
            Random rnd = new Random();

            Console.Clear();
            int hedef = SayiUret(rnd);
            int tahmin = 0;
            int puan = 50;
            Console.WriteLine($"Hile: {hedef}\n*******************\n");
            do
            {
                tahmin = TahminGir(i);
                if (tahmin == hedef)
                {
                    Win(puan);
                    break;
                }
                else
                {
                    Console.WriteLine(Kontrol(tahmin, hedef, i));
                    if (i == 5)
                    {
                        break;
                    }
                    puan -= 10;
                }
                i++;
            } while (i <= 5);
        }
        static void Main(string[] args)
        {
            do
            {
                Oyun();
            } while (Tekrar());
        }
    }
}
