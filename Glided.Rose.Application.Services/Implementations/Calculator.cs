using Glided.Rose.Application.Dtos;
using Glided.Rose.Application.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Application.Services.Implementations
{
    public class Calculator : ICalculator
    {
        private static readonly Dictionary<string, Dictionary<string, int>> _sphereValues = new()
        {
            { "Diamond",     new() { { "Chip", 1 },   { "Mark", 5 },   { "Broam", 20 } } },
            { "Garnet",      new() { { "Chip", 5 },   { "Mark", 25 },  { "Broam", 100 } } },
            { "Heliodor",    new() { { "Chip", 5 },   { "Mark", 25 },  { "Broam", 100 } } },
            { "Topaz",       new() { { "Chip", 5 },   { "Mark", 25 },  { "Broam", 100 } } },
            { "Ruby",        new() { { "Chip", 10 },  { "Mark", 50 },  { "Broam", 200 } } },
            { "Smokestone",  new() { { "Chip", 10 },  { "Mark", 50 },  { "Broam", 200 } } },
            { "Zircon",      new() { { "Chip", 10 },  { "Mark", 50 },  { "Broam", 200 } } },
            { "Amethyst",    new() { { "Chip", 25 },  { "Mark", 125 }, { "Broam", 500 } } },
            { "Sapphire",    new() { { "Chip", 25 },  { "Mark", 125 }, { "Broam", 500 } } },
            { "Emerald",     new() { { "Chip", 50 },  { "Mark", 250 }, { "Broam", 1000 } } },
        };

        public Task<int> CalculateToGold(CreateCurrencyDto currency)
        {
            if (!_sphereValues.ContainsKey(currency.Gemstone))
                throw new ArgumentException($"Gemstone '{currency.Gemstone}' no es válida.");

            var gemstoneValues = _sphereValues[currency.Gemstone];

            if (!gemstoneValues.ContainsKey(currency.CurrencyType))
                throw new ArgumentException($"Tipo '{currency.CurrencyType}' no es válido para {currency.Gemstone}.");

            int unitValue = gemstoneValues[currency.CurrencyType];
            int totalValue = unitValue * currency.Quantity;

            return Task.FromResult(totalValue);
        }
    }
}
