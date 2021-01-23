using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunNumara = 1;
            product1.UrunAdi = "Masa";
            product1.UrunFiyati = 360;
            product1.UrunKategorisi = "Ev Eşyası";

            Product product2 = new Product();
            product2.UrunNumara = 2;
            product2.UrunAdi = "TV";
            product2.UrunFiyati = 3000;
            product2.UrunKategorisi = "Elektronik";

            Product product3 = new Product();
            product3.UrunNumara = 3;
            product3.UrunAdi = "Bulaşık Makinası";
            product3.UrunFiyati = 4000;
            product3.UrunKategorisi = "Beyaz Eşya";

            Product[] urunDizi = new Product[] { product1, product2 ,product3};
            foreach (Product urun in urunDizi)
            {
                Console.WriteLine(urun.UrunNumara + "\n" + urun.UrunAdi + "\n" + urun.UrunFiyati + "\n" + urun.UrunKategorisi + "\n\n");
            }

            for(int i = 0; i < urunDizi.Length; i++)
            {
                Console.WriteLine(urunDizi[i].UrunNumara + "\n" + urunDizi[i].UrunAdi + "\n" + urunDizi[i].UrunFiyati + "\n" + urunDizi[i].UrunKategorisi + "\n\n");
            }

            int don = 0;
            while (don < urunDizi.Length)
            {
                Console.WriteLine(urunDizi[don].UrunNumara + "\n" + urunDizi[don].UrunAdi + "\n" + urunDizi[don].UrunFiyati + "\n" + urunDizi[don].UrunKategorisi + "\n\n");
                don++;
            }
        }
    }
}
