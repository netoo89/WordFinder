namespace WordFinderApp.Services.Matcher
{
    public interface IWordMatcher
    {
        int CountRowMatches(string row, string word);
    }
}
