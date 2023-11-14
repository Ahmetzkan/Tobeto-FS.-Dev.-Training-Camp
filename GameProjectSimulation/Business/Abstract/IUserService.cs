using GameProjectSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Business.Abstract
{
    public interface IUserService
    {
        bool Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
