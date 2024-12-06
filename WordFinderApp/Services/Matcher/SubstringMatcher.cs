namespace WordFinderApp.Services.Matcher
{
    public class SubstringMatcher : IWordMatcher
    {
        public int CountRowMatches(string row, string word)
        {
            var numberOfMatches = 0;

            var rowPosition = 0;

            while(rowPosition <= row.Length - word.Length)
            {
                var foundMatch = row.Substring(rowPosition, word.Length) == word;

                if (foundMatch)
                {
                    numberOfMatches++;
                    rowPosition += word.Length;
                }
                else
                {
                    rowPosition++;
                }
            }

            return numberOfMatches;
        }
    }
}