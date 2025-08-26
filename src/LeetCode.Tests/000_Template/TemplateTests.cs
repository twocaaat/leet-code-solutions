using LeetCode.Solutions._000_Template;

namespace LeetCode.Tests._000_Template;

public class TestTests 
{
    [Theory]
    [InlineData(10, 9)]
    public void Solution_Test(int input, int expectedOutput)
    {
        // arrange
        var solution = new Solution();
        
        // act
        var output = solution.Template(input);

        // assert
        Assert.Equal(expectedOutput, output);
    }
}