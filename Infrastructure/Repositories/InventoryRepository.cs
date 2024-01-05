using Application.Interfaces.Repositories;
using Domain.Entities;
using Shared.Repository;

namespace Infrastructure.Repositories
{
    public class InventoryRepository : BaseRepository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}