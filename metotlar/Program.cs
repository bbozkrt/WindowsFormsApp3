using System;

namespace metotlar
{
    class program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            int Fiyati = 15;
            string aciklama = "Amasya Elamsı";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyatı = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Armut";
            urun3.Fiyatı = 20;
            urun3.Aciklama = "Ankara armutu";

            Urun urun4 = new Urun();
            urun4.Adi = "kavun";
            urun4.Fiyatı = 25;
            urun4.Aciklama = "tatlı kavun";

            Urun urun5= new Urun();
            urun5.Adi = "çilek";
            urun5.Fiyatı = 25;
            urun5.Aciklama = "silifke çileği";


            Urun[] urunler = new Urun[] {urun1,urun2,urun3,urun4,urun5 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(Fiyati);
                Console.WriteLine(aciklama);
                Console.WriteLine("---------------");
            }
            Console.WriteLine("----------------------metotlar----");

            //instance=class örneği 
            sepet_menager sepet_Menager = new sepet_menager();
            sepet_Menager.Ekle(urun1);
            sepet_Menager.Ekle(urun2);
            sepet_Menager.Ekle(urun3);
            sepet_Menager.Ekle(urun4);
            sepet_Menager.Ekle(urun5);
            sepet_Menager.Ekle2("armut", 15, "yeşil");



        }
    }
}