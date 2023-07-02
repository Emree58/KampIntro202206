using System;

namespace Oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Engin Demirog
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.CustomerNo = "12345";
            musteri1.Name = "Engin";
            musteri1.LastName = "Demirog";
            musteri1.TcNo = "12345678910";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.CustomerNo = "54321";
            musteri2.CorpName = "Kodlama.io";
            musteri2.TaxNo = "1234567890";

            //Gercek Musteri - Tuzel(business) Musteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);


        }
    }
}
