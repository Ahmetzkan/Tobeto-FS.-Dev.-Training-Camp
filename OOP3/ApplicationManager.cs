using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Method Injection
    public class ApplicationManager
    {
        public void DoApplication(ICreditManager creditManager,List<ILoggerService> loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            creditManager.Calculate();

            foreach (ILoggerService logger in loggerService)
            {
                logger.Log();
            }
        }

        //Kredi ön bilgilendirmesini liste ile yap
        public void DoCreditPreliminaryInformation(List<ICreditManager> credits) 
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
