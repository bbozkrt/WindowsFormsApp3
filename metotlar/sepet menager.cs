using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class sepet_menager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrilker. Sepete eklendi : "+ urun.Adi);
        }
        public void Ekle2(string urunAdi, int fiyat, string aciklama) 
        {
            Console.WriteLine(" tebrikler. sepete eklendi : " + urunAdi);
        }
    }
}
