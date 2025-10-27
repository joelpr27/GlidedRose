using Glided.Rose.Application.Contracts;
using Glided.Rose.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Application.Services
{
    public class ItemCreator : IItemCreator
    {
        public LegendaryItem CreateLegendaryItem(string name)
        {
            return new LegendaryItem
            {
                Name = name,
            };
        }

        public MatureItem CreateMatureItem(string name, int sellIn, int Quality)
        {
            return new MatureItem
            {
                Name = name,
                SellIn = sellIn,
                Quality = Quality
            };
        }

        public StandardItem CreateStandardItem(string name, int sellIn, int Quality)
        {
            return new StandardItem
            {
                Name = name,
                SellIn = sellIn,
                Quality = Quality
            };
        }

        public BackstagePasses CreateBackstagePasses(string name, int sellIn, int Quality)
        {
            return new BackstagePasses
            {
                Name = name,
                SellIn = sellIn,
                Quality = Quality
            };
        }
    }
}
