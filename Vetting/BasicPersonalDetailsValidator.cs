using FluentExamples.Models;
using FluentValidation;

namespace FluentExamples.Vetting
{
    public class BasicPersonalDetailsValidator : AbstractValidator<PersonalDetails>
    {
        public BasicPersonalDetailsValidator()
        {
            RuleFor(pd => pd.EmailAddress).NotNull().NotEmpty();
            RuleFor(pd => pd.FirstName).NotNull().NotEmpty();
            RuleFor(pd => pd.LastName).NotNull().NotEmpty();
            RuleFor(pd => pd.MSISDN).NotNull().NotEmpty();
            RuleFor(pd => pd.Password).NotNull().NotEmpty();
        }
    }
}
