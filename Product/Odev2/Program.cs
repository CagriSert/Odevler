using System;
using System.Collections.Generic;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Çağrı");
            myDictionary.Add("Sert");
            Console.WriteLine(myDictionary.Count);
            foreach (var isim in myDictionary.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
