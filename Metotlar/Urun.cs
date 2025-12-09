using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
     class Urun  //classlarimiza prop - ozellik ekleriz   bu classlarin kullanimin 1. yolu 
                 //2. yolu manager yani servis bunlar bi operasyon tutar
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}
