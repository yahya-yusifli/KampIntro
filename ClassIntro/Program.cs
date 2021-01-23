using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmeni = "Yahya";
            kurs2.IzlenmeOrani = 55;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmeni = "Kerem";
            kurs3.IzlenmeOrani = 45;

            //Console.WriteLine(kurs1.KursAdi + " | " + kurs1.Egitmeni + " izlenme orani % " +kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " | " + kurs.Egitmeni + " izlenme orani % "+ kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
