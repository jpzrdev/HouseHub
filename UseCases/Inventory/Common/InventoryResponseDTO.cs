using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Application.Inventory.Common
{
    public class InventoryResponseDTO
    {
        public string Name { get; set; }
        public string ItemCategory { get; set; }
    }
}