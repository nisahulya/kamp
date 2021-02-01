using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }

        public String GameName { get; set; }

        public int Price { get; set; }

        public int Amount { get; set; }

        
    }
}
