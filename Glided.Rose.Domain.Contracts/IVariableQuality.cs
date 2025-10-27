using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Domain.Contracts
{
    public interface IVariableQuality
    {
        public int SellIn { get; set; }

        public void UpgradeQuality();
    }
}
