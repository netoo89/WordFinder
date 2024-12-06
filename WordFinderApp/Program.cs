using System.Diagnostics;
using WordFinderApp.Constants;
using WordFinderApp.Services.Matcher;
using WordFinderApp.Services.Finder;

namespace WordFinderApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var wordFinder = new WordFinder(MatrixConstants.Matrix);
            wordFinder.SetWordMatcherStragegy(new ReplaceMatcher());

            var watch = Stopwatch.StartNew();

            var topRepeatedWords = wordFinder.Find(MatrixConstants.Words);

            watch.Stop();

            Console.WriteLine($"\nTop {MatrixConstants.ReturnTop} repeated words");

            foreach (var word in topRepeatedWords)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine($"\nTime elapsed: {watch.Elapsed}");
        }
    }
}