using FluentExamples.Models;
using FluentValidation;

namespace FluentExamples.Vetting
{
    public class BareBasicValidator : AbstractValidator<PersonalDetails>
    {
        public BareBasicValidator()
        {
            RuleFor(pd => pd.EmailAddress).NotEmpty();
            RuleFor(pd => pd.FirstName).NotEmpty();
            RuleFor(pd => pd.LastName).NotEmpty();
            RuleFor(pd => pd.MSISDN).NotEmpty();
            RuleFor(pd => pd.Password).NotEmpty();
        }
    }
}
