using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlama başlangıc için temel kurs";
            string kurs3 = "java";

            //array - dizi

            string[] kurslar = new string[] { 
            
                    "Yazılım Geliştirici Yetiştirme Kampı",
                    "Programlama Başlangıc İçin Temek Kurs",
                    "java",
                    "phyton",
                    "react"
             };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("\nkurslar sonu");


            Console.WriteLine("foreach list \n\n");

            foreach(var item in kurslar)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
