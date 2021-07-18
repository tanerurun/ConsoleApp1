using System;

namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasit t = new Tasit();
            t.Hiz = 200;
            t.Marka = "Toyota";
            t.Renk = "Kırmızı";
            t.Yakit = "benzin";
            t.TasitInfo();
            
            Console.ReadKey();
        }
    }

    public class Tasit
    {
        public string Yakit;
        public int Hiz;
        public string Renk;
        public string Marka;
        public void TasitInfo()
        {
            string tasit = "Taşıt Markası :" + Marka + "Renk : " + Renk + " Yakıt :" + Yakit + "Hız :" + Hiz;
            Console.WriteLine(tasit);
        }
    }
}
