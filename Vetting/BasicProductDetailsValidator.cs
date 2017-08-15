using FluentExamples.Models;
using FluentValidation;

namespace FluentExamples.Vetting
{
    public class BasicProductDetailsValidator : AbstractValidator<ProductDetails>
    {
        public BasicProductDetailsValidator()
        {
            RuleFor(pd => pd.AdditionalEquipment).NotNull().NotEmpty();
            RuleFor(pd => pd.DealId).NotNull().NotEmpty();
            RuleFor(pd => pd.EquipmentDescription).NotNull().NotEmpty();
            RuleFor(pd => pd.ModelId).NotNull().NotEmpty();
            RuleFor(pd => pd.PayMethodId).NotNull().NotEmpty();
            RuleFor(pd => pd.Subscription).NotNull().NotEmpty();
        }
    }
}
