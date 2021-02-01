using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Buy1Free1Campaign : BaseCampaign, IEntity
    {
        public override String Name {
            get
            {
                return "Buy1Free1";
            }
            set
            {
                Name = "Buy1Free1";
            }
        }
    }
}
