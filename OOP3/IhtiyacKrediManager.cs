using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void Bakiye()
        {
            throw new NotImplementedException();
        }

        public void Doviz()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtyac kredisi palanı yapıldı.");
        }
    }
}
