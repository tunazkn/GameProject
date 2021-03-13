using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IOrderService
    {
        void Order(Gamer gamer, Game game);
        void OrderWithCampaign(Game game, Gamer gamer, Campaign campaign);
    }
}
