using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFinder.Services.Matcher
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
