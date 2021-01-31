using System;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "yazılım kursu", "kitap kursu", "mat kursu", "java kursu", "pyston" };



            for (int i = 0; i < kurslar.Length; i++) 

            {
                Console.WriteLine(kurslar[i]);
             }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);


            }



            Console.WriteLine("sayfa sonu");
        }
    }
}
