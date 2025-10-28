using Glided.Rose.Domain.Contracts;
using Glided.Rose.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Infrastructure.Repositories.Contracts
{
    public interface IItemCreator
    {
        object CreateItem(string type, string name, int? sellIn, int? quality, int goldValue);
    }
}
