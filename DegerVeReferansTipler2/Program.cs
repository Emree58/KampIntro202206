using System;

namespace DegerVeReferansTipler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 kac ? 30
            //aciklama: int, decimal, float, double, bool = deger tip = stake tip
            // stack= sayi1= 10, sayi2=30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] 999
            //aciklama: array, class, inheritance = referans tip


        }
    }
}
