using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar3
{
    internal class SepetManager
    {
        //naming convention(overeenkomst) isim kurali
        //Syntax
        // Urun(type) urun(hangi urun parametre)
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + urunAdi);
        }
    }
}
