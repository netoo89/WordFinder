using System.Text.RegularExpressions;

namespace WordFinder.Services.Matcher
{
    public class RegexMatcher : IWordMatcher
    {
        public int CountRowMatches(string row, string word)
        {
            // Ignore case for when row or word have uppercase letters
            return Regex.Count(row, word, RegexOptions.IgnoreCase);
        }
    }
}