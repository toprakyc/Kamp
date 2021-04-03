using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //logger injection
        public void BasvuruYap(ICrediManager crediManager, List<ILoggerService> loggerServices)
        {
            //başvuran bilgilerini değerlendirme
            //krediyi hesapla
            crediManager.Calculate();
            foreach (var  logger in loggerServices)
            {
                logger.Log();
            }
        }
        
        public void CrediOnBilgilendirmesiYap(List<ICrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Calculate();
            }
        }
    }
}
