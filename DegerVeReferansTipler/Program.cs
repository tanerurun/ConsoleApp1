using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;//BURADA DEĞER ATAMASI YAPILIR.
            sayi2 = 65;

            //sayi1
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;//BURADA REFERANSA NUMARALI BİR BİRİNE ATIYOR.
            sayilar2[0] = 999;
            //sayi1[0]
            
                Console.WriteLine(sayilar1[0]);
               

            //int ,decimal,float,double,bool=değer tiplerim   /stack yer alır
            //array,class,interface=referans değer  /heap yer alır.








            Console.ReadKey();
        }
    }
}
