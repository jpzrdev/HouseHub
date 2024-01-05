using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Shared.Repository;

namespace Domain.Interfaces.Repositories
{
    public interface IInventoryRepository : IBaseRepository<Domain.Entities.Inventory>
    {

    }
}