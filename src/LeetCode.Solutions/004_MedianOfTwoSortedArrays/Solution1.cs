namespace LeetCode.Solutions._004_MedianOfTwoSortedArrays;

// TODO: Improve speed (O(log(n + m)))
public class Solution1
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
       var medianPosition = (nums1.Length + nums2.Length) / 2;
       var isEven = (nums1.Length + nums2.Length) % 2 == 0;

       var num1Offset = 0;
       var num2Offset = 0;
       
       var median = 0.0;

       for (var i = 0; i < medianPosition + (isEven ? 0 : 1); i++)
       {
           median = PickNext(nums1, nums2, ref num1Offset, ref num2Offset);
       }

       if (isEven)
       {
           median += PickNext(nums1, nums2, ref num1Offset, ref num2Offset);
           median /= 2.0;
       }

       return median;
    }

    private int PickNext(int[] nums1, int[] nums2, ref int num1Offset, ref int num2Offset)
    {
        var num1 = num1Offset < nums1.Length ? nums1[num1Offset] : (int?)null;
        var num2 = num2Offset < nums2.Length ? nums2[num2Offset] : (int?)null;

        if (num1 < num2 || num2 is null)
        {
            num1Offset++;
            return num1 ?? 0;
        }
        
        num2Offset++;
        return num2 ?? 0;
    }
}