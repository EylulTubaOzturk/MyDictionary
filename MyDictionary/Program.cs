using MyDictionary;
using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> isim1 = new MyDictionary<int, string>();
            isim1.Add("Ahmet");
            isim1.Add("Burak");
            isim1.Add("Ayşe");
            Console.WriteLine(isim1.Count);

            MyDictionary<int, string> isim = new MyDictionary<int, string>();
            isim.Add("Elif");
            isim.Add("Mahmut");
            Console.WriteLine(isim.Count);
        }
    }
}
