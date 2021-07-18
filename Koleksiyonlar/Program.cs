using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {   //stack            //heap
            string[] isimler = new string[]
            {
                "Engin","Murat","Kerem","Halil"
            };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler = new string[5];//heap yeni bi referans numarası oluşturludu 5 elemanlı.
            isimler[4] = "ilker";//5. değere ilker eklenmiş diğerleri boş gelir.
            Console.WriteLine(isimler[4]);//ekrana ilker yazılır.
            Console.WriteLine(isimler[0]);//0,1,2,3 değerleri boş gelir bir atama yapılmamıştır.



            List<string> isimler2 = new List<string> { "Engin","Murat","Kerem","Halil"};//arrayler yerine kullanıyoruz.

        }
    }
}
