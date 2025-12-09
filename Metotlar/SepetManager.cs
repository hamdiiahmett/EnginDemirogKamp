using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun) //ekle metodu   ne eklemek istedigini parantez icine yazarsan parametre vermis olursun Urun tipinde urun ekledik 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi);
            //
            //
        }
        // bi classda birden fazla metot olabilir
        //public void Ekle2(string urunAdi, string aciklama, double fiyat)  da yazabilirdik ama sikintili
        //ama mudurun stokadedi de ekle diyince burdaki parametreyye ekliceksin ama programcsde de her birine yeni eklemen degistirmen gerekcek 
        //o yuzden classlar onemli urun classina stokadedi
        
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);
        }







    }
}
