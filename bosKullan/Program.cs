using System;

namespace bosKullan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kurs kurs1 = new Kurs();
            kurs1.KursId = 1;
            kurs1.KursIsim ="Ingilizce";
            kurs1.KursOgretmen = "Mahmut";

            Kurs kurs2 = new Kurs();
            kurs2.KursId = 2;
            kurs2.KursIsim = "Fransizca";
            kurs2.KursOgretmen = "Mehmet";

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursId + " " + kurs.KursIsim + " " + kurs.KursOgretmen);
            }
        }
    }


    class Kurs
    {
        public int KursId { get; set; }
        public string KursIsim { get; set; }
        public string KursOgretmen { get; set; }
            */



            Urun urun1 = new Urun();
            urun1.UrunId = 0;
            urun1.UrunAdi = "Laptop";
            urun1.UrunAciklama = "Gaming laptop'ta son model!";

            Urun urun2 = new Urun();
            urun2.UrunId = 1;
            urun2.UrunAdi = "Ekran";
            urun2.UrunAciklama = "Full LED 4K çözunurluk!";

            Urun[] urunler = new Urun[] {urun1,  urun2};

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunId + " :" + urunler[i].UrunAdi + " :" + urunler[i].UrunAciklama);
            }

        }


    class Urun
        {
            public int UrunId { get; set; }
            public string UrunAdi { get; set; }
            public string UrunAciklama { get; set; }

        }
    }
}
