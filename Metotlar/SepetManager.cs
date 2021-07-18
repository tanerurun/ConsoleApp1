using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convetion
        //syntax
        public static void Ekle(Product product)
        {
            //metot içersinde ne yapmak istersek onu yapıyoruz.
            //Ekle içersinde yüzlerce satır kod yazılabilir.

            Console.WriteLine("Tebrikler .Sepete Eklendi! :" + product.Adi);
        }
        public static void Ekle2(string urunAdi,double Fiyat,string Aciklama)
            
        {
            Console.WriteLine("Tebrikler .Sepete Eklendi! :" + urunAdi);
        }
        
    }
}
