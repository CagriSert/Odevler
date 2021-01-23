using System;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs = new Kurs();
            kurs.KursAdi = "C#";
            kurs.KursEgitmeni = "Çağrı SErt";
            kurs.izlenmeORanı = 68;
            
            Kurs kurs2 = new Kurs();
            kurs.KursAdi = "C#";
            kurs.KursEgitmeni = "Çağrı SErt";
            kurs.izlenmeORanı = 68;

            Kurs kurs3 = new Kurs();
            kurs.KursAdi = "C#";
            kurs.KursEgitmeni = "Çağrı SErt";
            kurs.izlenmeORanı = 68;
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string KursEgitmeni { get; set; }

        public int izlenmeORanı { get; set; }
    }
}
