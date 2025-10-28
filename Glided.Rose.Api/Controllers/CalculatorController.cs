
using Glided.Rose.Application.Dtos;
using Glided.Rose.Application.Services.Contracts;
using Glided.Rose.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Glided.Rose.Api.Controllers
{
    [ApiController]
    [Route("api/Calculator")]
    public class CalculatorController(ICalculator _calculator) : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> CalculateCurrency([FromBody] CreateCurrencyDto currency)
        {
            var result = await _calculator.CalculateToGold(currency);
            return Ok(result);
        }

    }
}
