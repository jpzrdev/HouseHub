using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Aggregates.IntentoryAggregate.Events
{
    public record StockDepletedEvent(Item item) : INotification
    {

    }
}