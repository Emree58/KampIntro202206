using System;
using System.Collections.Generic;

namespace OOP33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager =new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager= new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);
            //basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}

//Interfacelerde class in referans numarasini tutabiliyor
//01:44:10 IkrediManager.. cok karisti istersen tekrar izle 1:30:00 itibaren
//01:54:00 kreceptie?

//02:43:00