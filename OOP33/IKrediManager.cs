using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP33
{
    // Interface de herzaman IKrediManager I ile baslar
    // Interface is een sjabloon
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();

    }
}


//Kredi turu Interface mantigi:
/* class Kredimanager, If tasitkredi .. , If Konutkredi..
 * 300 tane degisik kredi olursa kod okunmaz hal alir.
 * Interface ile kod duzene giriyor
*/



