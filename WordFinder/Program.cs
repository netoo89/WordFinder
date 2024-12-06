using System.Diagnostics;
using WordFinder.Services.Matcher;

namespace WordFinder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var wordFinder = new WordFinder(Constants.Matrix);
            wordFinder.SetWordMatcherStragegy(new ReplaceMatcher());

            var watch = Stopwatch.StartNew();

            var topRepeatedWords = wordFinder.Find(Constants.Words);

            watch.Stop();

            Console.WriteLine($"\nTop {Constants.ReturnTop} repeated words");

            foreach (var word in topRepeatedWords)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine($"\nTime elapsed: {watch.Elapsed}");
        }
    }
}