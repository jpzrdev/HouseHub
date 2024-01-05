using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InventoryItem
    {
        public Item Item { get; private set; }
        public int Quantity { get; private set; }

        public static InventoryItem New(Item item, int quantity)
        {
            var inventoryItem = new InventoryItem
            {
                Item = item,
                Quantity = quantity
            };

            return inventoryItem;
        }

        public void UpdateQuantity(int newQuantity)
        {
            Quantity = newQuantity;
        }

        public void SubtractQuantity()
        {
            Quantity--;
        }

        public void AddQuantity()
        {
            Quantity++;
        }

        public void AddQuantity(int quantityToAdd)
        {
            Quantity += quantityToAdd;
        }
    }
}