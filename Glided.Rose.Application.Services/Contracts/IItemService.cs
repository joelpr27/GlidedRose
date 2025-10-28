using Glided.Rose.Domain.Contracts;

namespace Glided.Rose.Application.Services.Contracts
{
    public interface IItemService
    {
        List<object> GetItems();
        List<object> SimulateDays(int days);
    }
}