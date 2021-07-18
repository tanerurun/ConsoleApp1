using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager//urunle ilgili operasyonlar var bunun içinde 
    {
        //manager iş yapan class demek
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+ "Eklendi.  ");
            
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName +" Güncellendi.");
        }









        public int Topla(int x,int y)
        {
            
            return x + y;

        }

        public void Topla2(int x,int y)
        {
            Console.WriteLine(x+y);
        }

        //

        public void test(int sayi)
        {
            sayi = 999;
        }
    }
}
