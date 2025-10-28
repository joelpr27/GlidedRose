using Glided.Rose.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Application.Services.Contracts
{
    public interface ICalculator
    {
        Task<int> CalculateToGold(CreateCurrencyDto currency);
    }
}
