using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Entities.Concrete
{
    public class User
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public List<Game> PurchasedGames { get; set; } = new List<Game>();

    }
}
