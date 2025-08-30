using LeetCode.Solutions._007_ReverseInteger;

namespace LeetCode.Tests._007_ReverseInteger;

public class ReverseIntegerTests
{
    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    [InlineData( 2147483647, 0)]
    [InlineData( -2147483647, 0)]
    [InlineData( -2147483648, 0)]
    public void Solution1_Test(int input, int expectedOutput)
    {
        // arrange
        var solution = new Solution1();
        
        // act
        var output = solution.Reverse(input);

        // assert
        Assert.Equal(expectedOutput, output);
    }
    
    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    [InlineData( 2147483647, 0)]
    [InlineData( -2147483647, 0)]
    [InlineData( -2147483648, 0)]
    public void Solution2_Test(int input, int expectedOutput)
    {
        // arrange
        var solution = new Solution2();
        
        // act
        var output = solution.Reverse(input);

        // assert
        Assert.Equal(expectedOutput, output);
    }
}