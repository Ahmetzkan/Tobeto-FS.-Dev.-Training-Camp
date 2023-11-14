using GameProjectSimulation.Business.Abstract;
using GameProjectSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Business.Concrete
{
    public class UserManager : IUserService
    {

        private IVerificationService _verificationService;
        
        //EgovernmentVerification aşağıda verificationService oluyor.
        public UserManager(IVerificationService verificationService)
        {
            _verificationService = verificationService;
        }

        public bool Add(User user)
        {
            if (_verificationService.Verify(user))
            {
                Console.WriteLine("Registered successfully");
                return true;
            }
            else
            {
                Console.WriteLine("Verification failed,Registration unseccusfull");
                return false;
            }
        }

        public void Update(User user)
        {
            Console.WriteLine("Player updated");
        }


        public void Delete(User user)
        {
            Console.WriteLine("Player deleted");
        }

    
    }
}
