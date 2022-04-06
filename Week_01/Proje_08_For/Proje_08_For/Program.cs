using System;

namespace Proje_08_For
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            int toplam = 0;
                        for (int i = 1; i <= 10; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine(i);
                                toplam += i;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine(toplam);
                        Console.ReadLine();*/


            /*            int toplam = 0;
                        for (int i = 2; i <= 10; i+=2)
                        {
                            Console.WriteLine(i);
                            toplam += i;
                        }
                        Console.WriteLine();
                        Console.WriteLine(toplam);
                        Console.ReadLine();*/

            /* 1-100 arasındaki asal sayıları
             * ekrana yazdıran programı hazırlayınız.
             */
            /*            bool asal = true;
                        int s1 = 0;
                        int s2 = 0;
                        int s3 = 0;
                        for (int i = 2; i <= 300; i++)
                        {
                            for (int j = 2; j <i ; j++)
                            {
                                if (i % j == 0)
                                {
                                    asal = false;
                                    break;
                                }
                            }
                            if (asal)
                            {
                                if (i<=100)
                                {
                                    s1++;
                                }
                                else if (i<=200)
                                {
                                    s2++;
                                }
                                else
                                {
                                    s3++;
                                }
                            }
                            asal = true;
                        }
                        Console.WriteLine(@$"SONUÇ:
            0-100 Arası     : {s1}
            101-200 Arası   : {s2}
            201-300 Arası   : {s3}
            ");*/
            //Çarpım TAblosu

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i*j}\t");
                }
                Console.WriteLine();
            }
           Console.ReadLine();
        }
    }
}



