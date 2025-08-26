using LeetCode.Solutions._003_LongestSubstringWithoutRepeatingCharacters;

namespace LeetCode.Tests._003_LongestSubstringWithoutRepeatingCharacters;

public class LongestSubstringWithoutRepeatingCharactersTests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData(" ", 1)]
    [InlineData("dvdf", 3)]
    [InlineData("au", 2)]
    [InlineData("cdd", 2)]
    public void Solution_Test(string input, int expectedOutput)
    {
        // arrange
        var solution = new Solution();
        
        // act
        var output = solution.LengthOfLongestSubstring(input);

        // assert
        Assert.Equal(expectedOutput, output);
    }
}