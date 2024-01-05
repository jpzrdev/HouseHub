using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Inventory.Common;
using Domain.Enums;
using MediatR;

namespace Application.Inventory.Commands.CreateInventory
{
    public record CreateInventoryCommand(string Name, ItemCategory ItemCategory = ItemCategory.Undefined) : IRequest<InventoryResponseDTO>
    {
    }
}