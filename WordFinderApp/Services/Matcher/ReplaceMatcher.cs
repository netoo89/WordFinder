namespace WordFinderApp.Services.Matcher
{
    public class ReplaceMatcher : IWordMatcher
    {
        public int CountRowMatches(string row, string word)
        {
            var newRow = row.Replace(word, string.Empty);

            return (row.Length - newRow.Length) / word.Length;
        }
    }
}
