namespace WordFinder.Services.Matcher
{
    public class SubstringMatcher : IWordMatcher
    {
        public int CountRowMatches(string row, string word)
        {
            var numberOfMatches = 0;

            for (int i = 0; i <= row.Length - word.Length; i++)
            {
                var subString = row.Substring(i, word.Length);

                if (word == subString)
                {
                    numberOfMatches++;
                }
            }

            return numberOfMatches;
        }
    }
}