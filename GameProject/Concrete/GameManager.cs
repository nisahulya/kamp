﻿using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " added!");
        }


    }
}
