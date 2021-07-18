using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Engin";
            int yas = 36;


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin ";
            kurs1.IzlenemOrani = 64;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "taner";
            kurs2.IzlenemOrani = 770;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "haşim";
            kurs3.Egitmen = "berkay";
            kurs3.IzlenemOrani = 78889;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "html";
            kurs4.Egitmen = "murat";
            kurs4.IzlenemOrani = 1999;


            //Console.WriteLine(kurs1.KursAdi + " "+kurs1.Egitmen+" "+kurs1.IzlenemOrani);

            //Console.WriteLine(kurs2.KursAdi + " " + kurs2.Egitmen + " " + kurs2.IzlenemOrani);

            //Console.WriteLine(kurs3.KursAdi + " " + kurs3.Egitmen + " " + kurs3.IzlenemOrani);

            Kurs[] kurslar = new Kurs[] {
                kurs1,kurs2,kurs3,kurs4
            
            };

            foreach(var item in kurslar)
            {
                Console.WriteLine(item.KursAdi);
                Console.WriteLine(item.Egitmen);
                Console.WriteLine(item.IzlenemOrani);
            }


            //Console.WriteLine("Hello World!");
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenemOrani { get; set; }


    }
}
