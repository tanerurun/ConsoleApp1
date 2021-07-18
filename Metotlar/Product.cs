using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
   class Product
    {
        //PROPERTY - özellik
        public int Id { get; set; }//EŞSİZ DEĞER DİĞER ÜRÜNLERDE AYIRMAK İÇİN ID VERMEKTEN VAZ GELMEYELİM
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public string İmage { get; set; }
        public double Indirim { get; set; }
        public string Kategori { get; set; }
        public int StokAdedi { get; set; }


    }
}
