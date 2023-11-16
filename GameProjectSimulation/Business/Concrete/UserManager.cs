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

        private List<IVerificationService> _verificationServices;

        //EgovernmentVerification aşağıda verificationService oluyor.
        public UserManager(List<IVerificationService> verificationService) //additional = Ek
        {
            _verificationServices = verificationService;
        }

        

        public bool Add(User user)
        {
            foreach (var verificationService in _verificationServices)
            {
                if (verificationService.Verify(user))
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
            return true;
        }

        public void Update(User user)
        {
            Console.WriteLine("Player updated");
        }


        public void Delete(User user)
        {
            Console.WriteLine("Player deleted");
        }

        public void Save(User user)
        {
            foreach (var verificationService in _verificationServices)
            {
                verificationService.Save(user); 
            }
        }
    }
}
