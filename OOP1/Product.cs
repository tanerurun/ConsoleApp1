using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }/// <summary>
        /// ana anahtar bu dur
        /// </summary>
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        public int UnitInStok { get; set; }

        public string Image { get; set; }

        public int CategoryId { get; set; }//hangi kategorye dahil olduğunu belirtir.
      


    }
}
