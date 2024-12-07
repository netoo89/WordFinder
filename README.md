# WordFinder
Application that searches words in a string matrix

The purpose of this challenge is to solve the problem using the best performance possible and the least memory allocation.

Using the strategy design pattern, five different word matchers implementations were benchmarked (50,000 words), with the following results:

On Windows
![image](https://github.com/user-attachments/assets/2a2af82c-0698-45d0-bc19-d4839f541189)

On Mac
![image](https://github.com/user-attachments/assets/f8aca2c9-b42b-4d2d-8659-a793f1adbd46)

To improve performance the following actions were also made:

- Remove repeated words from wordstream
- Add all horizontal and vertical rows to a ReadOnlySpan<string> before searching the words in the matrix
- Save in the wordMatches dictionary only those words that we found (no entries with 0 matches)
- Use foreach loop instead of regular for loop, which seems to be faster when handling IEnumerable

A test project was included to run the different word matchers, every test founds the same number of words (located in the MatrixConstants class).

A benchmark project was included to found which matcher implementation was the best one.
