using WordFinderApp.Constants;
using WordFinderApp.Extensions;
using WordFinderApp.Services.Matcher;
using WordFinderApp.Validators;

namespace WordFinderApp.Services.Finder
{
    public class WordFinder
    {
        private readonly IEnumerable<string> _matrix;

        private IWordMatcher _wordMatcher;

        public WordFinder(IEnumerable<string> matrix)
        {
            var matrixValidator = new MatrixValidator();
            var validationResult = matrixValidator.Validate(matrix);

            if (!validationResult.IsValid)
            {
                validationResult.PrintErrors();
            }

            _matrix = matrix;
        }

        public void SetWordMatcherStragegy(IWordMatcher wordMatcher)
        {
            _wordMatcher = wordMatcher;
        }

        public IEnumerable<string> Find(IEnumerable<string> wordStream)
        {
            var wordStreamValidator = new WordStreamValidator();
            var validationResult = wordStreamValidator.Validate(wordStream);

            if (!validationResult.IsValid)
            {
                validationResult.PrintErrors();

                return [];
            }

            // Remove repeated words
            wordStream = wordStream.Distinct();

            var wordMatches = new Dictionary<string, int>();

            var numberOfHorizontalRows = _matrix.Count();

            var numberOfVerticalRows = _matrix.FirstOrDefault()?.Length;

            foreach (var word in wordStream)
            {
                var numberOfMatches = 0;

                // Horizontal look up
                for (var row = 0; row < numberOfHorizontalRows; row++)
                {
                    var currentHorizontalRow = _matrix.ElementAt(row);

                    numberOfMatches += _wordMatcher.CountRowMatches(currentHorizontalRow, word);
                }

                // Vertical look up
                for (var column = 0; column < numberOfVerticalRows; column++)
                {
                    var currentVerticalRow = _matrix.Select(r => r.ElementAt(column)).ToArray();

                    numberOfMatches += _wordMatcher.CountRowMatches(new string(currentVerticalRow), word);
                }

                // Only create an entry in the dictionary for those words that are found to save memory
                if (numberOfMatches > 0)
                {
                    wordMatches[word] = numberOfMatches;
                }
            }

            foreach (var pair in wordMatches)
            {
                Console.WriteLine($"'{pair.Key}' found {pair.Value} times");
            }

            return wordMatches.OrderByDescending(wm => wm.Value)
                              .Take(MatrixConstants.ReturnTop)
                              .Select(wm => wm.Key);
        }
    }
}