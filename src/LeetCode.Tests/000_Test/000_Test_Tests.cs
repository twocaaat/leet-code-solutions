using LeetCode.Solutions._000_Test;

namespace LeetCode.Tests._000_Test;

public class TestTests 
{
    [Fact]
    public void CallSolution_ReturnValidAnswer()
    {
        // arrange
        var input = 10;
        var expectedOutput = 9; // 10 - 1 = 9
        
        // act
        var output = Solution.MinusOne(input);

        // assert
        Assert.Equal(expectedOutput, output);
    }
}