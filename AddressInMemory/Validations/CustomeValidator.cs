using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressInMemory.Validations
{
    public class CustomeValidator : AbstractValidator<Address>
    {
        public CustomeValidator()
        {
            RuleFor(m => m.PersonName).NotEmpty().MinimumLength(1).MaximumLength(50);
            RuleFor(m => m.FlateNo).NotEmpty().MinimumLength(1).MaximumLength(8);
            RuleFor(m => m.BuildingNo).NotEmpty().MaximumLength(5);
            RuleFor(m => m.City).NotEmpty().MaximumLength(15);
            RuleFor(m => m.State).NotEmpty().MaximumLength(30);
            RuleFor(m => m.PinCode).NotEmpty().MaximumLength(15);

            //RuleFor(m => m.PinCode).NotEmpty().ValidCustomerType();

            // Anothe examples
            //RuleFor(m => m.EmailAddress).EmailAddress();
            //RuleFor(m => m.FirstName).NotEmpty().When(m => m.Type.ToLower() == "person")
            //  .WithMessage("'First Name' must be populated in for customers of type 'Person'");
        }

    }
}
