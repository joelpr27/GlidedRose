using Glided.Rose.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Infrastructure.Repositories.Contracts
{
    public interface IJsonReader
    {
        List<object> ReadItems();
    }
}
