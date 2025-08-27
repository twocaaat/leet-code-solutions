using LeetCode.Solutions._005_LongestPalindromicSubstring;

namespace LeetCode.Tests._005_LongestPalindromicSubstring;

public class LongestPalindromicSubstringTests
{
    [Theory]
    [InlineData("babad", "bab")]
    [InlineData("cbbd", "bb")]
    [InlineData("aacabdkacaa", "aca")]
    public void Solution_Test(string input, string expectedOutput)
    {
        // arrange
        var solution = new Solution();
        
        // act
        var output = solution.LongestPalindrome(input);

        // assert
        Assert.Equal(expectedOutput, output);
    }
}