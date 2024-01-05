using Application.Inventory.Common;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Inventory.Commands.CreateInventory
{
    public class CreateInventoryCommandHandler : IRequestHandler<CreateInventoryCommand, InventoryResponseDTO>
    {
        private readonly IInventoryRepository _inventoryRepository;
        public CreateInventoryCommandHandler(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task<InventoryResponseDTO> Handle(CreateInventoryCommand request, CancellationToken cancellationToken)
        {
            return new InventoryResponseDTO() { Name = request.Name, ItemCategory = "Indefinida" };
        }
    }
}