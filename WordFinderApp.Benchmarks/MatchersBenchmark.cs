using BenchmarkDotNet.Attributes;
using WordFinderApp.Constants;
using WordFinderApp.Services.Finder;
using WordFinderApp.Services.Matcher;

namespace WordFinderApp.Benchmarks
{
    [MemoryDiagnoser]
    public class MatchersBenchmark
    {
        [Params(50000)]
        public int WordsSize;

        private WordFinder _wordFinder;

        private IEnumerable<string> _words;

        [GlobalSetup]
        public void Setup()
        {
            _wordFinder = new WordFinder(MatrixConstants.Matrix);

            _words = Enumerable.Range(1, WordsSize).Select(x => $"Test{x}");
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            _words = [];
        }

        [Benchmark]
        public void RegexMatcher()
        {
            var regexMatcher = new RegexMatcher();

            _wordFinder.SetWordMatcherStragegy(regexMatcher);

            _wordFinder.Find(_words);
        }

        [Benchmark]
        public void SubstringMatcher()
        {
            var subStringMatcher = new SubstringMatcher();

            _wordFinder.SetWordMatcherStragegy(subStringMatcher);

            _wordFinder.Find(_words);
        }

        [Benchmark]
        public void SplitMatcher()
        {
            var splitMatcher = new SplitMatcher();

            _wordFinder.SetWordMatcherStragegy(splitMatcher);

            _wordFinder.Find(_words);
        }

        [Benchmark]
        public void ReplaceMatcher()
        {
            var replaceMatcher = new ReplaceMatcher();

            _wordFinder.SetWordMatcherStragegy(replaceMatcher);

            _wordFinder.Find(_words);
        }

        [Benchmark]
        public void CharCompareMatcher()
        {
            var charCompareMatcher = new CharCompareMatcher();

            _wordFinder.SetWordMatcherStragegy(charCompareMatcher);

            _wordFinder.Find(_words);
        }
    }
}
