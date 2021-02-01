using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class HalfToHalfCampaign : BaseCampaign, IEntity
    {
        public override String Name
        {
            get
            {
                return "HalfToHalfCampaign";
            }
            set
            {
                Name = "HalfToHalfCampaign";
            }
        }
    }
}
