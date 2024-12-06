namespace WordFinder.Services.Matcher
{
    public class CharCompareMatcher : IWordMatcher
    {
        public int CountRowMatches(string row, string word)
        {
            var numberOfMatches = 0;

            var rowArray = row.ToCharArray();

            for (int i = 0; i <= rowArray.Length - word.Length; i++)
            {
                var wordIndex = 0;

                for (int j = i + wordIndex; j < i + word.Length; j++)
                {
                    if (rowArray[j] != word[wordIndex])
                    {
                        break;
                    }

                    wordIndex++;
                }

                if (wordIndex == word.Length)
                {
                    numberOfMatches++;
                }
            }

            return numberOfMatches;
        }
    }
}
