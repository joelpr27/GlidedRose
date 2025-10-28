using Glided.Rose.Domain.Contracts;
using System.Text.Json;

namespace Glided.Rose.Infrastructure.Repositories.Implementations
{
    public class JsonReader : IJsonReader
    {
        private readonly string _filePath = @"C:\Users\Holacons\Desktop\University\Glided.Rose\Data\Items.json";
        private readonly ItemCreator _creator = new();


        public List<object> ReadItems()
        {
            if (!File.Exists(_filePath))
                throw new FileNotFoundException($"No se encontró el archivo: {_filePath}");

            var json = File.ReadAllText(_filePath);
            using var doc = JsonDocument.Parse(json);

            var items = new List<object>();

            foreach (var element in doc.RootElement.EnumerateArray())
            {
                string type = element.GetProperty("Type").GetString()!;
                string name = element.GetProperty("Name").GetString()!;
                int? sellIn = element.TryGetProperty("SellIn", out var s) ? s.GetInt32() : null;
                int? quality = element.TryGetProperty("Quality", out var q) ? q.GetInt32() : null;
                int goldValue = element.GetProperty("GoldValue").GetInt32();

                var item = _creator.CreateItem(type, name, sellIn, quality, goldValue);
                items.Add(item);
            }

            return items;
        }
    }
}
