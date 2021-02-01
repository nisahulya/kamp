using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class Buy1Free1CampaignManager : BaseCampaignManager, ISellManager
    {
        public void Sell(Game game, Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Sell(Game game, Gamer gamer, BaseCampaign baseCampaign)
        {
            game.Amount = 2 * game.Amount;
            Console.WriteLine(game.Amount + " " + game.GameName + " was/were sold to " + 
                gamer.FirstName + " for "+ game.Price);
            game.Amount = game.Amount/2;
        }

    }
}
