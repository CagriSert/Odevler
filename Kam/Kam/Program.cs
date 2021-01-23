using System;

namespace Kam
{
    class Program
    {
        static void Main(string[] args)
        {
            // typemsafety -- Tip Güvenliği
            // Do not repeat yourself -- Kendini Tekrarlama
            // değer tutucu -- alias
            /*
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if(dolarDun > dolarBugun)
                Console.WriteLine("Azalış Oku");
            
            else if (dolarDun < dolarBugun)
                Console.WriteLine("Artış Oku");
            
            else
                Console.WriteLine("Eşittiy Oku");
            */
            string[] kurslar = new string[] {"Yazılım", "Programlama", "Java"};
            Console.WriteLine(kurslar[1]);

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
       

        }
    }
}
