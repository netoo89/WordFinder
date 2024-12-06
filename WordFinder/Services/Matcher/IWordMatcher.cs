using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFinder.Services.Matcher
{
    public interface IWordMatcher
    {
        int CountRowMatches(string row, string word);
    }
}
