using GameProjectSimulation.Business.Abstract;
using GameProjectSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Business.Concrete
{
    public class SmsVerificationManager : IVerificationService
    {
        public bool Save(User user)
        {
            Console.WriteLine("Saved to database: " + " " + user.FirstName + " " + user.LastName);
            return true;

        }

        public bool Verify(User user)
        {
            Console.WriteLine("Sms is verified");
           return true;
        }

    }
}

