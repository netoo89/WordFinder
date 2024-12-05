using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFinder
{
    public static class Constants
    {
        public const int MatrixMaxRowNumber = 64;
        public const int MatrixMaxColumnNumber = 64;
        public const int ReturnTop = 10;

        public static readonly IEnumerable<string> Words =
        [
            "cold",
            "wind",
            "snow",
            "chill",
            "cold",
            "chill",
            "sun",
            "cloud",
            "flower",
        ];

        public static readonly IEnumerable<string> Matrix =
        [
            "abcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdc",
            "fgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwio",
            "chillchillchillchillchillchillchillchillchillchillchillchill",
            "pqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsd",
            "uvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxy",
            "chillchillchillchillchillchillchillchillchillchillchillchill",
            "coldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldx",
            "COLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDe",
            "abcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdc",
            "fgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwio",
            "chillchillchillchillchillchillchillchillchillchillchillchill",
            "pqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsd",
            "uvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxy",
            "chillchillchillchillchillchillchillchillchillchillchillchill",
            "coldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldx",
            "COLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDe",
            "abcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdc",
            "fgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwio",
            "chillchillchillchillchillchillchillchillchillchillchillchill",
            "pqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsd",
            "uvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxy",
            "chillchillchillchillchillchillchillchillchillchillchillchill",
            "coldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldx",
            "COLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDe",            
            "abcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdc",
            "fgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwio",
            "chillchillchillchillchillchillchillchillchillchillchillchill",
            "pqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsd",
            "uvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxy",
            "chillchillchillchillchillchillchillchillchillchillchillchill",
            "coldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldx",
            "COLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDe",
            "abcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdc",
            "fgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwio",
            "chillchillchillchillchillchillchillchillchillchillchillchill",
            "pqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsd",
            "uvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxy",
            "chillchillchillchillchillchillchillchillchillchillchillchill",
            "coldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldx",
            "COLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDe",            
            "abcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdcabcdc",
            "fgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwiofgwio",
            "chillchillchillchillchillchillchillchillchillchillchillchill",
            "pqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsdpqnsd",
            "uvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxyuvdxy",
            "chillchillchillchillchillchillchillchillchillchillchillchill",
            "coldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldxcoldx",
            "COLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDeCOLDe",
        ];
    }
}
