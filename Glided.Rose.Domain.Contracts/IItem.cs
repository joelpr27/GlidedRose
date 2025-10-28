using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Domain.Contracts
{
    public interface IItem
    {
        public string Name { get; }
        public int Quality { get; }
        decimal GetDepreciatedValue();
    }
}
