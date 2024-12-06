namespace WordFinderApp.Services.Matcher
{
    public class SplitMatcher : IWordMatcher
    {
        public int CountRowMatches(string row, string word)
        {
            return row.Split(word).Length - 1;
        }
    }
}