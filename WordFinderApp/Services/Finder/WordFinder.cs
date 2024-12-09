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
                throw new ArgumentException(string.Join(", ", validationResult.Errors));
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

            // Get horizontal and vertical rows as a ReadOnlySpan to increase performance and reduce memory usage
            var rows = GetRows();

            var words = new ReadOnlySpan<string>([..wordStream]);

            foreach (var word in words)
            {
                var numberOfMatches = 0;

                foreach(var currentRow in rows)
                {
                    numberOfMatches += _wordMatcher.CountRowMatches(currentRow, word);
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

        private ReadOnlySpan<string> GetRows()
        {
            var rows = new List<string>(_matrix);

            var numberOfColumns = _matrix.FirstOrDefault()?.Length ?? 0;

            for (var column = 0; column < numberOfColumns; column++)
            {
                var verticalRow = _matrix.Select(r => r[column]);

                rows.Add(string.Concat(verticalRow));
            }

            return new ReadOnlySpan<string>([.. rows]);
        }
    }
}