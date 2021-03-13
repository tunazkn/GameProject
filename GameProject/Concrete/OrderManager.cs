using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Order(Gamer gamer, Game game)
        {
            Console.WriteLine("Sayın " + gamer.FirstName + " " + gamer.LastName + " " 
                + game.GameName + " Oyununu " + game.Price + " TL' ye Satın Aldınız"); 
        }

        public void OrderWithCampaign(Game game, Gamer gamer, Campaign campaign)
        {
            decimal discountedPrice = (game.Price - (game.Price * campaign.DiscountRate) / 100);

            Console.WriteLine("Sayın " + gamer.FirstName + " " + gamer.LastName + " " + campaign.CampainName
                + " " + game.GameName + " Oyununu " + discountedPrice + " TL' ye Satın Aldınız");
        }
    }
}
