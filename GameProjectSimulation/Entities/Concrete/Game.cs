using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Entities.Concrete
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  Campaign? Campaign { get; set; }
        public int Level { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

    }
}
