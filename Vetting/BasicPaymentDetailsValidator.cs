using FluentExamples.Models;
using FluentValidation;

namespace FluentExamples.Vetting
{
    public class BasicPaymentDetailsValidator : AbstractValidator<PaymentDetails>
    {
        public BasicPaymentDetailsValidator()
        {
            RuleFor(pd => pd.AccountNumber).NotNull().NotEmpty();
            RuleFor(pd => pd.AccountType).NotNull().NotEmpty();
            RuleFor(pd => pd.BankName).NotNull().NotEmpty();
            RuleFor(pd => pd.BranchCode).NotNull().NotEmpty();
            RuleFor(pd => pd.DebitDay).NotNull().NotEmpty();
            RuleFor(pd => pd.PaymentRef).NotNull().NotEmpty();
            RuleFor(pd => pd.PaymentType).NotNull().NotEmpty();
        }
    }
}
