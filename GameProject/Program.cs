using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                BirthOfYear = 1996,
                FirstName = "TUNA",
                LastName = "ÖZKAN",
                IdentityNumber = 01010101010
            };
            gamerManager.Add(gamer1);
            Console.WriteLine("----------------------------");

            CampaignManager campaingManager = new CampaignManager();
            Campaign campaign1 = new Campaign { CampaingId =1 , CampainName = " %60 İNDİRİMLİ ", DiscountRate = 60  };
            Campaign campaign2 = new Campaign { CampaingId = 2, CampainName = " %80 İNDİRİMLİ ", DiscountRate = 80 };
            campaingManager.Add(campaign1);

            Console.WriteLine("----------------------------");

            GameManager gameManager = new GameManager();
            Game game1 = new Game { GameId = 1, GameName = "Pubg", Price = 170 };
            Game game2 = new Game { GameId = 2, GameName = "CS: GO", Price = 240 };

            gameManager.Add(game2);
            gameManager.Update(game1);

            Console.WriteLine("----------------------------");

            OrderManager orderManager = new OrderManager();
          
            orderManager.OrderWithCampaign(game1, gamer1, campaign1);
            orderManager.Order(gamer1, game2);

            Console.WriteLine("----------------------------");

            Console.WriteLine("Hello World! :)");
        }
    }
}
