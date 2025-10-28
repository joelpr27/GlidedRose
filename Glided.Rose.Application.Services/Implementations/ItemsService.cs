using Glided.Rose.Application.Services.Contracts;
using Glided.Rose.Domain.Contracts;
using Glided.Rose.Infrastructure.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Application.Services.Implementations
{
    public class ItemsService(IJsonReader _jsonReader) : IItemService
    {
        public List<object> GetItems()
        {
            return _jsonReader.ReadItems();
        }

        public List<object> SimulateDays(int days)
        {
            var items = _jsonReader.ReadItems();

            for (int day = 1; day <= days; day++)
            {
                foreach (var item in items)
                {
                    if (item is IVariableQuality variableQuality)
                        variableQuality.UpgradeQuality();
                }
            }

            return items;
        }
    }
}
