using GameProjectSimulation.Business.Abstract;
using GameProjectSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Business.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game Added");
        }

        public void Remove(Game game)
        {
            Console.WriteLine("Game removed");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game updated");
        }
    }
}
