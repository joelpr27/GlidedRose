using Glided.Rose.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Domain.Entities
{
    public class LegendaryItem : IItem
    {
        public string Name { get; set; }
        public int Quality { get; } = 80;

        public ValueObject BaseValue { get; set; }

        public LegendaryItem(string name, int quality, int goldValue)
        {
            Name = name;
            Quality = quality;
            BaseValue = new ValueObject(goldValue);

        }
        public decimal GetDepreciatedValue()
        {
            return BaseValue.GoldPiece * (Quality / 100);
        }
    }
}
