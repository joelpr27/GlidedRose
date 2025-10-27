using Glided.Rose.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Domain.Entities
{
    public class MatureItem : IItem, IVariableQuality
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

            if (Quality < 50)
            {
                if (SellIn >= 0)
                {
                    Quality++;
                }
                else
                {
                    Quality += 2;

                    if (Quality > 50)
                    {
                        Quality = 50;
                    }
                }
            }
        }
    }
}
