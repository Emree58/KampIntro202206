using System;

namespace ClassMetotDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Mehmet";
            musteri1.Soyad = "Uçar";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ismet";
            musteri2.Soyad = "Duser";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Musteri bilgisi: " + musteri.Ad + " " + musteri.Soyad);
                Console.WriteLine("Musteri Numarasi: " + musteri.Id);
            }
        }
    }
}
