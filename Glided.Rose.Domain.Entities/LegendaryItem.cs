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
    }
}
