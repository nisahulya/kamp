using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseCampaignManager
    {
        public void Add(BaseCampaign baseCampaign)
        {
            Console.WriteLine(baseCampaign.Name + " added!");
        }

        public void Delete(BaseCampaign baseCampaign)
        {
            Console.WriteLine(baseCampaign.Name + " deleted!");
        }

        public void Update(BaseCampaign baseCampaign)
        {
            Console.WriteLine(baseCampaign.Name + " updated!");
        }
    }
}
