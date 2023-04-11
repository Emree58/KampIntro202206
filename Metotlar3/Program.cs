using System;

namespace Metotlar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //class:
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " :" + urun.Aciklama + " :" + urun.Fiyati);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("-----------------Metotlar----------------------");

            //Instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yesil armut", 12,10);
            sepetManager.Ekle2("Elma", "Yesil elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakir karpuzu", 12,8);
        }
    }
}
