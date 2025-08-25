using LeetCode.Solutions._001_TwoSum;

namespace LeetCode.Tests._001_TwoSum;

public class TwoSumTests 
{
    [Theory]
    [InlineData(new[] { 2,7,11,15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3,2,4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] {3,3 }, 6, new[] { 0, 1 })]
    public void CallSolution_ReturnValidAnswer(int[] nums, int target, int[] expectedOutput)
    {
        // arrange
        // act
        var output = Solution.TwoSum(nums, target);

        // assert
        Assert.Equal(expectedOutput, output);
    }
}