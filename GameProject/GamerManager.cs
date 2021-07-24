using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        //somutlaştırma işlemi yapıldı yukardaki metotla 

        public void Add(Gamer gamer)
        {
             if(_userValidationService.validate(gamer)==true)
            {
                Console.WriteLine("Kayıt EKLENDİ");
            }
             else
            {
                Console.WriteLine("Doğrulama başarısız .kayıt başarısız.");
            }
      
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt SİLİNDİ");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt GÜNCELLENDİ");
        }
    }
}
