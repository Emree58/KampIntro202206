using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP33
{
    internal class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Basvuran bilgilerini degerlendirme
            //
            // Yanlis kullanim -> KonutKrediManager konutKrediManager= new KonutKrediManager();
            // Ustteki kullanim ile tum BasvuruYap methodlar konutkredi olarak hesaplanir. KULLANMA
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
