using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class Item
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public ItemCategory Category { get; private set; }

        public static Item New(string name, ItemCategory Category = ItemCategory.Undefined)
        {
            var item = new Item
            {
                Id = new Guid(),
                Name = name,
                Category = Category
            };

            return item;
        }
    }
}