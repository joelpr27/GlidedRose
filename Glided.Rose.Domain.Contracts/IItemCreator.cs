
namespace Glided.Rose.Domain.Contracts
{
    public interface IItemCreator
    {
        object CreateItem(string type, string name, int? sellIn, int? quality, int goldValue);
    }
}
