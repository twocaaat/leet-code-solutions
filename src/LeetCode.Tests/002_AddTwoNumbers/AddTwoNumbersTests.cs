using LeetCode.Solutions._002_AddTwoNumbers;
using LeetCode.Solutions._002_AddTwoNumbers.Adds;

namespace LeetCode.Tests._002_AddTwoNumbers;

// 002
public class AddTwoNumbersTests
{
    [Theory]
    [InlineData(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8 })]
    [InlineData(new[] { 0 }, new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 }, new[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
    [InlineData(new[] { 2, 4, 9 }, new[] { 5, 6, 4, 9 }, new[] { 7, 0, 4, 0, 1 })]
    [InlineData(new[] { 9 }, new[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 })]
    [InlineData(new[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
        new[] { 5, 6, 4 },
        new[] { 6, 6, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 })]
    public void Solution_Test(int[] list1Arr, int[] list2Arr, int[] expectedOutput)
    {
        // arrange
        var l1 = ListNode.FromArray(list1Arr);
        var l2 = ListNode.FromArray(list2Arr);

        var solution = new Solution();

        // act
        var output = solution.AddTwoNumbers(l1, l2);

        // assert
        Assert.Equal(expectedOutput, output.ToArray());
    }
}