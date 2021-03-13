using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign Added: {0}", campaign.CampainName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign Updated: {0}", campaign.CampainName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Deleted!");
        }
    }
}
