using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 10, sayi2 = 30;
            DortIslem tp = new DortIslem();
            tp.Toplama(sayi, sayi2);
            tp.Toplama(45, 99);
            Console.WriteLine("Hello World!");
        }
    }
}
