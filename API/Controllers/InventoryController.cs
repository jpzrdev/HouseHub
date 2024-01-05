using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Requests.CreateInventory;
using Application.Inventory.Commands.CreateInventory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("inventories")]
    public class InventoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public InventoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateInventory([FromBody] CreateInventoryRequest request)
        {
            return Ok(await _mediator.Send(new CreateInventoryCommand(request.Name!)));
        }
    }
}