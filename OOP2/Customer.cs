using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Customer
    {
        /*1 özelikler  2 operasyon classlar bu işlemleri yapar fakat 
         ikisini bir yerde yapmıyoruz farklı classlarda yapmalıyız.*/
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CompanayaName { get; set; }
        public string TCKNO { get; set; }
        public string TaxNo { get; set; }//vergi numarası

    }
}
