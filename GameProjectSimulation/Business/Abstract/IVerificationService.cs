using GameProjectSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Business.Abstract
{
    public interface IVerificationService
    {
        bool Verify(User user);

        bool Save(User user);
       
    }
}
