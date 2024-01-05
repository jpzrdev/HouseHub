using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;
using SharedKernel.Domain;

namespace Domain.Entities
{
    public class Inventory : EntityBase, IAggregateRoot
    {
        public string? Name { get; private set; }
        public ItemCategory ItemCategory { get; private set; }
        private List<InventoryItem>? _items = new List<InventoryItem>();
        public IReadOnlyCollection<InventoryItem> Items => _items!;

        public static Inventory New(string name, ItemCategory itemCategory = ItemCategory.Undefined)
        {
            var inventory = new Inventory
            {
                Id = new Guid(),
                Name = name,
                ItemCategory = itemCategory
            };

            return inventory;
        }

        public void AddItem(Item item, int quantity = 1)
        {
            if (!_items!.Any(x => x.Item == item))
            {
                InventoryItem.New(item, quantity);
            }
            else
            {
                _items!.Single(i => i.Item == item).AddQuantity(quantity);
            }
        }

        public void RemoveItem(Item item, int quantity)
        {
            if (!_items!.Any(x => x.Item == item))
            {
                throw new ArgumentException("Item not found in inventory.");
            }
            else
            {
                _items!.Remove(_items.Single(x => x.Item == item));
            }
        }

        public void UpdateName(string newName)
        {
            Name = newName;
        }
    }
}