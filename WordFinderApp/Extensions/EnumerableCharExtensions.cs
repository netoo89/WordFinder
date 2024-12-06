using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFinderApp.Extensions
{
    public static class EnumerableCharExtensions
    {
        public static string CastToString(this IEnumerable<char> chars)
        {
            return string.Concat(chars);
        }
    }
}
