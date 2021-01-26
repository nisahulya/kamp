using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGameManager
    {
        void Sell(Gamer gamer, Game game);

        void Add(Game game);
    }

    
}
