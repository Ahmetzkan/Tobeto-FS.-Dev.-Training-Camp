using GameProjectSimulation.Business.Abstract;
using GameProjectSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign updated");
        }
    }
}
