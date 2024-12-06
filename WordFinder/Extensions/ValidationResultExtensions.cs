using FluentValidation.Results;

namespace WordFinder.Extensions
{
    public static class ValidationResultExtensions
    {
        public static void PrintErrors(this ValidationResult validationResult)
        {
            validationResult.Errors.ForEach(error =>
            {
                Console.Write(error);
            });
        }
    }
}
