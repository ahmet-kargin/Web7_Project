using System;

namespace Proje_03_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------VERİ TİPLERİ--------------");
            Console.WriteLine("A) Tamsayılar(Integral)");
            Console.WriteLine("I) İşaretsiz(Unsigned) Tamsayılar");

            Console.WriteLine("1) byte:");
            Console.WriteLine($"Minimum Değer: {byte.MinValue}");
            Console.WriteLine($"Maximum Değer: {byte.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(byte)} byte");

            Console.WriteLine("2) ushort:");
            Console.WriteLine($"Minimum Değer: {ushort.MinValue}");
            Console.WriteLine($"Maximum Değer: {ushort.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(ushort)} byte");

            Console.WriteLine("3) uint:");
            Console.WriteLine($"Minimum Değer: {uint.MinValue}");
            Console.WriteLine($"Maximum Değer: {uint.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(uint)} byte");

            Console.WriteLine("4) ulong:");
            Console.WriteLine($"Minimum Değer: {ulong.MinValue}");
            Console.WriteLine($"Maximum Değer: {ulong.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(ulong)} byte");

            Console.WriteLine("I) Signed");
            Console.WriteLine("1) sbyte");
            Console.WriteLine($"Minimum Değer: {sbyte.MinValue}");
            Console.WriteLine($"Maximum Değer: {sbyte.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(sbyte)} byte");

            Console.WriteLine("2) short");
            Console.WriteLine($"Minimum Değer: {short.MinValue}");
            Console.WriteLine($"Maximum Değer: {short.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(short)} byte");

            Console.WriteLine("3) int");
            Console.WriteLine($"Minimum Değer: {int.MinValue}");
            Console.WriteLine($"Maximum Değer: {int.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(int)} byte");

            Console.WriteLine("4) long");
            Console.WriteLine($"Minimum Değer: {long.MinValue}");
            Console.WriteLine($"Maximum Değer: {long.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(long)} byte");

            Console.WriteLine("B) Ondalıklı Sayılar(Decimal)");
            Console.WriteLine("1) float");
            Console.WriteLine($"Minimum Değer: {float.MinValue}");
            Console.WriteLine($"Maximum Değer: {float.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(float)} byte");

            Console.WriteLine("2) decimal");
            Console.WriteLine($"Minimum Değer: {decimal.MinValue}");
            Console.WriteLine($"Maximum Değer: {decimal.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(decimal)} byte");

            Console.WriteLine("3) double");
            Console.WriteLine($"Minimum Değer: {double.MinValue}");
            Console.WriteLine($"Maximum Değer: {double.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(double)} byte");

            Console.WriteLine("C) bool");
            Console.WriteLine($"Minimum Değer: {true}");
            Console.WriteLine($"Maximum Değer: {false}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(bool)} byte");

            Console.WriteLine("D) char");
            Console.WriteLine($"Minimum Değer: {(int)char.MinValue}");
            Console.WriteLine($"Maximum Değer: {(int)char.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu: {sizeof(char)} byte");
            char kod;
            kod = 'r';

            Console.WriteLine("E) DateTime");
            Console.WriteLine($"Minimum Değer: {DateTime.MinValue}");
            Console.WriteLine($"Maximum Değer: {DateTime.MaxValue}");
            unsafe
            {
                Console.WriteLine($"Bellekteki Boyutu: {sizeof(DateTime)} byte");
            }
                Console.ReadLine();
        }
    }
}
