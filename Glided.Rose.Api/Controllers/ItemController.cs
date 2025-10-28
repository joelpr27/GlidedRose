
using Glided.Rose.Application.Services.Contracts;
using Glided.Rose.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Glided.Rose.Api.Controllers
{
    [ApiController]
    [Route("api/GlidedRose")]
    public class ItemController(IItemService _itemService) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            return Ok(_itemService.GetItems());
        }

        [HttpGet("simulate/{days}")]
        public async Task<IActionResult> SimulateDays(int days)
        {
            var items = _itemService.SimulateDays(days);

            return Ok(items);
        }

    }
}
