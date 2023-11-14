using GameProjectSimulation.Business.Abstract;
using GameProjectSimulation.Business.Concrete;
using GameProjectSimulation.Entities.Concrete;


User user1 = new User()
{
    Id = 1,
    TcNo = "12345678901",
    FirstName = "Ahmet",
    LastName = "Özkan",
    BirthYear = 1999
};


Game game1 = new Game()
{
    Id = 1,
    Name = "Assassins Creed",
    Level = 3,
    Price = 300,
    Stock = 999999
};



Campaign campaign1 = new Campaign()
{
    Id =1,
    Name = "%BlackFriday",
    Discount = 25
};


// parametre olarak giden goverment usermanager da verification oluyor.
UserManager userManager = new UserManager(new EgovernmenentVerificationService() );
userManager.Add(user1);

Console.WriteLine("--------------------");

userManager.Update(user1);
userManager.Delete(user1);

Console.WriteLine("--------------------");


GameManager gameManager = new GameManager();
gameManager.Add(game1);
gameManager.Update(game1);
gameManager.Remove(game1);

Console.WriteLine("--------------------");


CampaignManager campaignManager = new CampaignManager();
campaignManager.Add(campaign1);
campaignManager.Update(campaign1);
campaignManager.Delete(campaign1);

Console.WriteLine("--------------------");


ISalesService salesService = new SaleManager();
salesService.SellGame(user1, game1);



