using FluentExamples.Models;
using FluentValidation;
using System.Text;

namespace FluentExamples.Vetting
{
    public class RuleSetValidator : AbstractValidator<CreateRequest>
    {
        public RuleSetValidator()
        {
            RuleSet("TopUp", () =>
            {
                //RuleFor(cr => cr.PaymentDetails.AccountType)
                //    .NotNull()
                //    .When(cr => !string.IsNullOrWhiteSpace(cr.PaymentDetails.AccountType))
                //    .WithMessage("AccountType is Must...");
              
                RuleFor(cr => cr.PersonalDetails.EmailAddress).NotEmpty();
                RuleFor(cr => cr.ProductDetails.ModelId).NotEmpty();
                RuleFor(cr => cr.PaymentDetails.AccountType).NotEmpty();
            });

            RuleSet("Credit", () =>
            {
                RuleFor(cr => cr.PaymentDetails.AccountType).NotNull().NotEmpty();
                RuleFor(cr => cr.PersonalDetails.EmailAddress).NotNull().NotEmpty();
            });

            RuleFor(cr => cr.ProductDetails.Subscription).NotNull().NotEmpty();
        }       
    }

   
}
