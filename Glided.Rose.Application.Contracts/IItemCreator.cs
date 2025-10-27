using Glided.Rose.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Application.Contracts
{
    public interface IItemCreator
    {
        StandardItem CreateStandardItem(string name, int sellIn, int Quality);
        MatureItem CreateMatureItem(string name, int sellIn, int Quality);
        LegendaryItem CreateLegendaryItem(string name);
        BackstagePasses CreateBackstagePasses(string name, int sellIn, int Quality);

    }
}
