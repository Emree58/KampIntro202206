using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java";
            string kurs4 = "C++";

            //array - dizi

            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi", 
                "Programlamaya baslangic icin temel kurs", "Java", "Python", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("----------For bitti----------------------------------------");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
            */
            // array
            string kurs1 = "Csharp";
            string kurs2 = "Temel";
            string kurs3 = "Java";
            string[] kurslar = new string[] {"Csharp", "Temel", "Java", "Python" };


            /*for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            */
            Console.WriteLine("FOREACH-------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu -- Footer");
        }
    }
}
