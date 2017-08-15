using FluentExamples.Models;
using FluentValidation;
using FluentValidation.Results;

namespace FluentExamples.Vetting
{
    public class ComplexTypeValidator : AbstractValidator<CreateRequest>
    {
        public ComplexTypeValidator()
        {
            RuleFor(pd => pd.PersonalDetails).SetValidator(new BasicPersonalDetailsValidator());
            RuleFor(pd => pd.ProductDetails).SetValidator(new BasicProductDetailsValidator());
            RuleFor(pd => pd.PaymentDetails).SetValidator(new BasicPaymentDetailsValidator());
        }

        //public override ValidationResult Validate(ValidationContext<CreateRequest> context)
        //{
        //    var result = base.Validate(context);

        //    result.

        //    return result;
        //}
    }
}
