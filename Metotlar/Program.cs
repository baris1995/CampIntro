using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya";
            urun1.stokAdedi = 20;


            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır";
            urun2.stokAdedi = 79;


            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun urun in urunler)

            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdedi);
                Console.WriteLine("doneeee"); 
            }
             
            
            Console.WriteLine("------------Metodla--------");

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("armut", "yeşil", 15,5);
            sepetmanager.Ekle2("elma", "kırmızı", 10,5);



        }
    }
}
