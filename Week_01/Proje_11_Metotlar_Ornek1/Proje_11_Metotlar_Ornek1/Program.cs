using System;

namespace Proje_11_Metotlar_Ornek1
{
    class Program
    {

        static void Main(string[] args)
        {
            int VeriGir(int sira)
            {
                Console.Write($"{sira}.sayıyı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                return sayi;
            }

            int Topla(int number1, int number2)
            {
                return number1 + number2;
            }
            int Cikar(int number1, int number2)
            {
                return number1 - number2;
            }
            int Carp(int number1, int number2)
            {
                return number1 * number2;
            }
            int Bol(int number1, int number2)
            {
                return number1 / number2;
            }

            int Islem(int number1, int number2=20, string islemTuru="+")
            {
                if (islemTuru=="+")
                {
                    return number1 + number2;
                }
                else if (islemTuru=="-")
                {
                    return number1 - number2;
                }
                else if (islemTuru=="*")
                {
                    return number1 * number2;
                }
                else
                {
                    return number1 / number2;
                }
            }


            int sayi1 = VeriGir(1);
            int sayi2 = VeriGir(2);
            //Console.WriteLine(Islem(sayi1, , "+");
            Console.WriteLine(Islem(islemTuru: "*", number1:sayi1));
/*            Console.WriteLine(Topla(sayi1,sayi2));
            Console.WriteLine(Cikar(sayi1,sayi2));
            Console.WriteLine(Carp(sayi1,sayi2));
            Console.WriteLine(Bol(sayi1,sayi2));*/

            Console.ReadLine();
        }
    }
}
