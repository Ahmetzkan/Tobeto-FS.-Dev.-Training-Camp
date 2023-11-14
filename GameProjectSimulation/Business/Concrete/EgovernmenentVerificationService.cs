using GameProjectSimulation.Business.Abstract;
using GameProjectSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Business.Concrete
{
    public class EgovernmenentVerificationService:IVerificationService
    {
        public bool Verify(User user)
        {
            return user.TcNo.Length == 11 && user.BirthYear > 1900;
        }
    }
}
