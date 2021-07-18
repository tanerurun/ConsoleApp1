using System;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ograncisayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapilmisMi = false;
            //sistemeGirisYapilmisMi = true;

            double dolarDun = 7.8;
            double dolarBugun = 7.80;
            if(dolarDun>dolarBugun)
            {
                Console.WriteLine("dolar düne göre düşmüş");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış similatörünü gösterin");
            }

            else
            {
                Console.WriteLine("Değişmedi dolar değeri");
            }

         




    
         
            Console.ReadKey();
        }
    }
}
