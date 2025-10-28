using Glided.Rose.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Application.Contracts
{
    public interface IPassDays
    {
        public string Pass25DaysNotLegendary(StandardItem item);
    }
}
