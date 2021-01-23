using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazilim gelistirici";
            string kurs2 = "temel kurs ";
            string kurs3 = "java";

            string[] kurslar = new string[] { "yazilim gelistirici", "temel kurs " ,"java","python","C++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("=====================================================");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("=============sayfa sonu============");
        }
    }
}
