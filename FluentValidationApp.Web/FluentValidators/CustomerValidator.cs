using FluentValidation;
using FluentValidationApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.FluentValidators
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} alani bo$ alamaz";
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x => x.Email).NotEmpty().WithMessage(NotEmptyMessage)
                .EmailAddress().WithMessage("Email alani dogru formatta olmalidir");
            RuleFor(x => x.Age).NotEmpty().WithMessage(NotEmptyMessage)
                .InclusiveBetween(18, 60)
                .WithMessage("Age alani 18 ile 60 arasinda olmalidir.");

            RuleFor(x => x.BirthDay).NotEmpty().WithMessage(NotEmptyMessage).Must(x=>
            {
                return DateTime.Now.AddYears(-18) >= x;
            }).WithMessage("Yasiniz 18 ya$indan buyuk olmalidir");

            RuleFor(x=>x.Gender).IsInEnum().WithMessage("{PropertyName} alans Erikek=1, Bayan=2 olmalidir");

            RuleForEach(x => x.Adresses).SetValidator(new AdressValidator());
        }
    }
}
