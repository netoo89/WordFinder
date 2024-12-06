using FluentValidation;
using WordFinderApp.Constants;

namespace WordFinderApp.Validators
{
    public class MatrixValidator : AbstractValidator<IEnumerable<string>>
    {
        public MatrixValidator()
        {
            RuleFor(matrix => matrix).NotNull().WithMessage(ErrorConstants.NullMatrixError);
            RuleFor(matrix => matrix).Must(HaveValidNumberOfRows).WithMessage(ErrorConstants.InvalidNumberOfRowsError);
            RuleFor(matrix => matrix).Must(HaveValidNumberOfColumns).WithMessage(ErrorConstants.InvalidNumberOfColumnsError);
            RuleFor(matrix => matrix).Must(HaveRowsWithSameLength).WithMessage(ErrorConstants.RowsDifferentLengthError);
        }

        protected bool HaveValidNumberOfRows(IEnumerable<string> matrix)
        {
            return matrix.Count() <= MatrixConstants.MatrixMaxRowNumber;
        }

        protected bool HaveValidNumberOfColumns(IEnumerable<string> matrix) 
        {
            return !matrix.Any(r => r.Length > MatrixConstants.MatrixMaxColumnNumber);
        }

        protected bool HaveRowsWithSameLength(IEnumerable<string> matrix)
        {
            return !matrix.Any(r => r.Length != matrix.FirstOrDefault()?.Length);
        }
    }
}
