using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artis butonu");
            }
            else
            {
                Console.WriteLine("degismedi butonu");
            }
            


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giris yap");
            }



           
        }
    }
}
