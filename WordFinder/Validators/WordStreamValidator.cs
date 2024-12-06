using FluentValidation;

namespace WordFinder.Validators
{
    public class WordStreamValidator : AbstractValidator<IEnumerable<string>>
    {
        public WordStreamValidator()
        {
            RuleFor(stream => stream).NotNull().WithMessage("Word stream is null");
        }
    }
}