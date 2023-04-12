using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo2
{
    internal class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Musteri: " + musteri.Ad + " " + musteri.Soyad + " Eklendi.");
        }

        public void MusteriListeleme(Musteri musteri)
        {
            Console.WriteLine("Musteri: " + musteri.Ad + " " + musteri.Soyad + ".");
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Musteri: " + musteri.Ad + " " + musteri.Soyad + " Silindi.");
        }
    }
}
