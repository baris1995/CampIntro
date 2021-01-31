using System;

namespace _17._01
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 7.65;
            double dolarBugun = 7.65;

            if (dolarBugun<dolarDun)
            { Console.WriteLine("Azalış OKU");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("artış Oku");
               }
             else
            { Console.WriteLine("eşittir oku");
            }

           




        }
    }
}
