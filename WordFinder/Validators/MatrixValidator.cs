using FluentValidation;

namespace WordFinder.Validators
{
    public class MatrixValidator : AbstractValidator<IEnumerable<string>>
    {
        public MatrixValidator()
        {
            RuleFor(matrix => matrix).NotNull().WithMessage("The matrix has no assigned value");
            RuleFor(matrix => matrix).Must(HaveValidNumberOfRows).WithMessage("The matrix has more rows than expected");
            RuleFor(matrix => matrix).Must(HaveValidNumberOfColumns).WithMessage("At least one of the rows have more characters than expected");
            RuleFor(matrix => matrix).Must(HaveRowsWithSameNumberOfColumns).WithMessage("Not all rows have the same length");
        }

        protected bool HaveValidNumberOfRows(IEnumerable<string> matrix)
        {
            return matrix.Count() <= Constants.MatrixMaxRowNumber;
        }

        protected bool HaveValidNumberOfColumns(IEnumerable<string> matrix) 
        {
            return !matrix.Any(r => r.Length > Constants.MatrixMaxColumnNumber);
        }

        protected bool HaveRowsWithSameNumberOfColumns(IEnumerable<string> matrix)
        {
            return !matrix.Any(r => r.Length != matrix.FirstOrDefault()?.Length);
        }
    }
}
