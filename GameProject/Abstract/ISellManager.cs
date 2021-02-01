using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISellManager
    {
        void Sell(Game game, Gamer gamer);

        void Sell(Game game, Gamer gamer, BaseCampaign baseCampaign);
    }
}
