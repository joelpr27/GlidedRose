using Glided.Rose.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Domain.Entities
{
    public class StandardItem : IItem, IVariableQuality
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public ValueObject BaseValue { get; set; }

        public StandardItem(string name, int sellIn, int quality, int goldValue)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
            BaseValue = new ValueObject(goldValue);

        }
        public decimal GetDepreciatedValue()
        {
            return BaseValue.GoldPiece * (Quality / 100);
        }

        public void UpgradeQuality()
        {
            SellIn--;

            if (Quality > 0)
            {
                if (SellIn >= 0)
                {
                    Quality--;
                }
                else
                {
                    Quality -= 2;
                }
            }
        }
    }
}
