using LeetCode.Solutions._004_MedianOfTwoSortedArrays;

namespace LeetCode.Tests._004_MedianOfTwoSortedArrays;

public class MedianOfTwoSortedArraysTests
{
    [Theory]
    [InlineData(new[] { 1, 3 }, new[] { 2 }, 2.0)]
    [InlineData(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
    [InlineData(new[] { 0, 0 }, new[] { 0, 0 }, 0)]
    [InlineData(new int[] { }, new[] { 1 }, 1)]
    [InlineData(new[] { 1 }, new int[] { }, 1)]
    public void Solution1_Test(int[] nums1, int[] nums2, double expectedOutput)
    {
        // arrange
        var solution = new Solution1();

        // act
        var output = solution.FindMedianSortedArrays(nums1, nums2);

        // assert
        Assert.Equal(expectedOutput, output);
    }
    
    [Theory]
    [InlineData(new[] { 1, 3 }, new[] { 2 }, 2.0)]
    [InlineData(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
    [InlineData(new[] { 0, 0 }, new[] { 0, 0 }, 0)]
    [InlineData(new int[] { }, new[] { 1 }, 1)]
    [InlineData(new[] { 1 }, new int[] { }, 1)]
    public void Solution2_Test(int[] nums1, int[] nums2, double expectedOutput)
    {
        // arrange
        var solution = new Solution2();

        // act
        var output = solution.FindMedianSortedArrays(nums1, nums2);

        // assert
        Assert.Equal(expectedOutput, output);
    }
}