using WordFinderApp.Services.Matcher;

public class SliceMatcher : IWordMatcher
{
    public int CountRowMatches(string row, string word)
    {
        var numberOfMatches = 0;

        var rowPosition = 0;

        ReadOnlySpan<char> rowSpan = row.AsSpan();
        ReadOnlySpan<char> wordSpan = word.AsSpan();

        while (rowPosition <= rowSpan.Length - wordSpan.Length)
        {
            var match = rowSpan.Slice(rowPosition, wordSpan.Length).SequenceEqual(wordSpan);

            if (match)
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
