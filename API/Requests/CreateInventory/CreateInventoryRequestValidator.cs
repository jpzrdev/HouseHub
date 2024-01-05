using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace API.Requests.CreateInventory
{

    public class CreateInventoryRequestValidator : AbstractValidator<CreateInventoryRequest>
    {
        public CreateInventoryRequestValidator()
        {
            RuleFor(x => x.Name)
              .NotEmpty()
              .WithMessage("Name is required.")
              .MinimumLength(2)
            ;
        }
    }
}