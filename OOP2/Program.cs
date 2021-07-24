using System;

namespace OOP2//VİDEO 5
{
    class Program
    {
        static void Main(string[] args)
        {
            //TANER ÜRÜN
            //Customer customer1 = new Customer();
            //customer1.Name = "Taner";
            //customer1.LastName = "ürün";
            //customer1.Id = 1;
            //customer1.TCKNO = "3444";
            //customer1.CustomerId = "4444";
            //customer1.CompanayaName = "Nuhsoft";
            //Console.WriteLine("Hello World!");

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.CustomerId = "1222";
            musteri1.Name = "Taner";
            musteri1.LastName = "Ürün";
            musteri1.TCKNO = "1111";
            musteri1.Id = 1;


            //bir tane tüzelmüşteri girelim
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.CustomerId = "444";
            musteri2.CompanayaName = "Kodlama.io";
            musteri2.TaxNo = "4444";

            Customer musteri3 = new GercekMusteri();//new gördüğümüzde referans numarası 
            Customer musteri4 = new TuzelMusteri();//Customer hem gercekmusteri hemde tüzelmusterileri tutabiliyor.
            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            musterimanager.Ekle(musteri3);
        }
    }
}
