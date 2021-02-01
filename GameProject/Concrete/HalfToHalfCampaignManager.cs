using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class HalfToHalfCampaignManager : BaseCampaignManager, ISellManager
    {
        public void Sell(Game game, Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Sell(Game game, Gamer gamer, BaseCampaign baseCampaign)
        {
            game.Price = game.Price / 2;
            Console.WriteLine(game.Amount +" "+ game.GameName + " was sold to " + gamer.FirstName + " for " + game.Price);
            game.Price = game.Price * 2;
        }

    }
}
