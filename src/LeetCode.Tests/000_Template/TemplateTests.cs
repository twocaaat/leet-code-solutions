using LeetCode.Solutions._000_Template;

namespace LeetCode.Tests._000_Template;

public class TestTests 
{
    [Fact]
    public void CallSolution_ReturnValidAnswer()
    {
        // arrange
        var input = 10;
        var expectedOutput = 9; // 10 - 1 = 9
        var solution = new Solution();
        
        // act
        var output = solution.Template(input);

        // assert
        Assert.Equal(expectedOutput, output);
    }
}