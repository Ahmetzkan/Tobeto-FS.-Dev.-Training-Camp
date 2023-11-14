using GameProjectSimulation.Business.Abstract;
using GameProjectSimulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Business.Concrete
{
    public class SaleManager:ISalesService
    {
        public void SellGame(User user,Game game)
        {
            if (game.Campaign != null)
            {
                decimal discountAmount = (game.Price * game.Campaign.Discount)/100 ;
                game.Price -= discountAmount;
            }

            user.PurchasedGames.Add(game);
            Console.WriteLine("You purchased the game: " + game.Name);
        }
    }
}
