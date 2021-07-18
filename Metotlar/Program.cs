using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Blue;
            string urunAdi = "Elma";
            double fiyat = 111;
            string açıklama = "Amasya elması";



            Product urun1 = new Product();//clasın örneği deniyor.
            urun1.Adi = "Elma";
            urun1.Fiyati = 333;
            urun1.Aciklama = "Emasya elması";
            // bir class oluşturuyoruz ortak olan özellikleri ekliyoruz böyle istediğimiz zaman class örneğini oluşturp
            // bilgileri kullanabilyoruz.


            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 8;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] {urun1,urun2 };


            foreach(var item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine(item.Fiyati);

            }

            Console.WriteLine("------Metotlar-------------------");

            SepetManager sepeteEkle = new SepetManager();
            SepetManager.Ekle(urun1);
            SepetManager.Ekle(urun2);

            SepetManager.Ekle2("armut",  12,"yeşil armut");


         

            //Console.WriteLine("Hello World!");
            //int a = 5, b = 100;
            //tesst.topla(a, b);
            //Console.ReadKey();
          
        }
    }
   //public class  tesst
   // {
   //        public static void topla (int x,int y)
   //     {
   //         int toplam = 0;
   //         toplam = x + y;
   //         Console.WriteLine("Toplam =  "+toplam);
   //     }
   // }
}



