using Glided.Rose.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Domain.Entities
{
    public class BackstagePasses : IItem, IVariableQuality
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void UpgradeQuality()
        {
            SellIn--;

            if (Quality == 0)
            {
                return;
            }

            switch (SellIn)
            {
                case > 10:
                    break;
                case > 5:
                    Quality += 2;
                    break;
                case >= 0:
                    Quality += 3;
                    break;
                default:
                    Quality = 0;
                    break;
            }
        }
    }
}
