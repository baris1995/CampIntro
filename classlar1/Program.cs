using System;

namespace classlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            kurs kurs1 = new kurs();
            kurs1.kursAdi = "c";
            kurs1.Egitmen = "engin";
            kurs1.izlenmeOrani = 78;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "java";
            kurs2.Egitmen = "baris";
            kurs2.izlenmeOrani = 68;

            kurs kurs3= new kurs();
            kurs3.kursAdi = "ptyıh";

            kurs3.Egitmen = "brua";
            kurs3.izlenmeOrani = 58;



            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar) 
            {
                Console.WriteLine(kurs.Egitmen);

            }


            Urun urun1 = new Urun();
            urun1.UrunAdi = "pantalon";
            urun1.Renk = "mavi";
            urun1.Beden = 28;
            
            Urun urun2 = new Urun();
            urun2.UrunAdi = "tshirt";
            urun2.Renk = "mbeyaz";
            urun2.Beden = 33;
            
            Urun urun3 = new Urun();
            urun3.UrunAdi = "mont";
            urun3.Renk = "kırmızı";
            urun3.Beden = 35;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3, };


            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + ":" + urun.Beden + ":" + urun.Renk);

            }





        }
    }

    class kurs
    {
        public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }

    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public string Renk { get; set; }
        public int  Beden { get; set; }

    }

}
