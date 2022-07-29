using System;

namespace KampIntro202206
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip guvenligi
            string kategoriEtiketi = "Kategori";
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artis butonu");
            }
            else
            {
                Console.WriteLine("Degismedi butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Lutfen giris yap");
            }
        }
    }
}
