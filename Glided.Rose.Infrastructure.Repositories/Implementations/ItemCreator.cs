using Glided.Rose.Domain.Contracts;
using Glided.Rose.Domain.Entities;
using Glided.Rose.Infrastructure.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Infrastructure.Repositories.Implementations
{
    public class ItemCreator : IItemCreator
    {
        public object CreateItem(string type, string name, int? sellIn, int? quality, int goldValue)
        {
            return type switch
            {
                "StandardItem" => new StandardItem(name, sellIn ?? 0, quality ?? 0, goldValue),
                "MatureItem" => new MatureItem(name, sellIn ?? 0, quality ?? 0, goldValue),
                "LegendaryItem" => new LegendaryItem(name, quality ?? 0, goldValue),
                "BackstagePasses" => new BackstagePasses(name, sellIn ?? 0, quality ?? 0, goldValue),
                "ConjuredItem" => new ConjuredItem(name, sellIn ?? 0, quality ?? 0, goldValue),
            };
        }
    }
}
