using System.Diagnostics;
using WordFinder.Services.Matcher;

namespace WordFinder.Tests
{
    public class WordFinderTests
    {
        private WordFinder _wordFinder;

        private IEnumerable<string> _words;

        private Stopwatch _watch;

        [SetUp]
        public void Setup()
        {
            _wordFinder = new WordFinder(Constants.Matrix);

            _words = Constants.Words;

            _watch = new Stopwatch();
        }

        [TearDown]
        public void TearDown()
        {
            _wordFinder = null;
            _words = null;
            _watch = null;
        }

        [Test]
        public void TestRegexMatcher()
        {
            var regexMatcher = new RegexMatcher();

            TestMatcher(regexMatcher);
        }

        [Test]
        public void TestSubstringMatcher()
        {
            var subStringMatcher = new SubstringMatcher();

            TestMatcher(subStringMatcher);
        }

        [Test]
        public void TestSplitMatcher()
        {
            var splitMatcher = new SplitMatcher();

            TestMatcher(splitMatcher);
        }

        [Test]
        public void TestReplaceMatcher()
        {
            var replaceMatcher = new ReplaceMatcher();

            TestMatcher(replaceMatcher);
        }

        [Test]
        public void TestCharCompareMatcher()
        {
            var charCompareMatcher = new CharCompareMatcher();

            TestMatcher(charCompareMatcher);
        }

        private void TestMatcher(IWordMatcher matcher)
        {
            _watch.Restart();

            _wordFinder.SetWordMatcherStragegy(matcher);

            var topRepeatedWords = _wordFinder.Find(_words);

            _watch.Stop();

            PrintTestDetails(matcher.GetType().Name, topRepeatedWords);
        }

        private void PrintTestDetails(string matcherName, IEnumerable<string> topRepeatedWords)
        {
            Console.WriteLine($"\nTop {Constants.ReturnTop} repeated words");

            foreach (var word in topRepeatedWords)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine($"\nTime elapsed: {_watch.Elapsed} with matcher {matcherName}");
        }
    }
}
