using System;

namespace Ders2Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunAdi = "Galaxy S22 Ultra";
            urun1.urunBilgi = "Samsung'un en son çikan telefon modeli.";
            urun1.urunFiyat = 1300;

            Urun urun2 = new Urun();
            urun2.urunAdi = "Iphone 13 Pro";
            urun2.urunBilgi = "Apple'in en son çikan telefon modeli.";
            urun2.urunFiyat = 1400;

            Urun[] urunler = new Urun[] {urun1, urun2 };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunAdi + ": " + urunler[i].urunBilgi + ": " + urunler[i].urunFiyat + " Euro");
            }
            Console.WriteLine("-----For bitti-----");
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + ": " + urun.urunBilgi + ": " + urun.urunFiyat + " Euro ");
            }
            Console.WriteLine("-----Foreach bitti-----");
            int x = 0;
            while (x<urunler.Length)
            {
                Console.WriteLine(urunler[x].urunAdi);
                x++;
            }
            Console.WriteLine("-----while bitti-----");
        }

        class Urun
        {
            public string urunAdi { get; set; }
            public string urunBilgi { get; set; }
            public int urunFiyat { get; set; }
        }
    }
}
