namespace WordFinderApp.Services.Matcher
{
    public class CharCompareMatcher : IWordMatcher
    {
        public int CountRowMatches(string row, string word)
        {
            var numberOfMatches = 0;

            var rowArray = row.ToCharArray();

            var rowIndex = 0;

            // foreach(var rowIndex in Enumerable.Range(0, row.Length - word.Length + 1))
            // for(int rowIndex = 0; rowIndex <= row.Length - word.Length; rowIndex++)
            while(rowIndex <= rowArray.Length - word.Length)
            {
                var rowPosition = rowIndex;

                var found = true;

                foreach(var wordChar in word)
                {
                    if (rowArray[rowPosition] != wordChar)
                    {
                        found = false;
                        break;
                    }

                    rowPosition++;
                }

                if (found)
                {
                    numberOfMatches++;
                    rowIndex += word.Length;
                }
                else
                {
                    rowIndex++;
                }
            }

            return numberOfMatches;
        }
    }
}
