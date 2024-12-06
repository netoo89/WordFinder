using FluentValidation;
using WordFinderApp.Constants;

namespace WordFinderApp.Validators
{
    public class WordStreamValidator : AbstractValidator<IEnumerable<string>>
    {
        public WordStreamValidator()
        {
            RuleFor(stream => stream).NotNull().WithMessage(ErrorConstants.NullWordStreamError);
        }
    }
}