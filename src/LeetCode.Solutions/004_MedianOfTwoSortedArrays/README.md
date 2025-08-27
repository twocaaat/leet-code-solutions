# 4. Median of Two Sorted Arrays

![Hard](https://img.shields.io/badge/-Hard-ff2d55?style=flat)


Given two sorted arrays `nums1` and `nums2` of size `m` and `n` respectively, return **the median** of the two sorted arrays.

The overall run time complexity should be `O(log (m+n))`.

**Example 1:**

> **Input:**  nums1 = [1,3], nums2 = [2] \
> **Output:** 2.00000 \
> **Explanation:** merged array = [1,2,3] and median is 2.

**Example 2:**

> **Input:**  nums1 = [1,2], nums2 = [3,4] \
> **Output:** 2.50000 \
> **Explanation:** merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

**Constraints:**

* `nums1.length == m`
* `nums2.length == n`
* `0 <= m <= 1000`
* `0 <= n <= 1000`
* `1 <= m + n <= 2000`
* `-10^6 <= nums1[i], nums2[i] <= 10^6`

---

# Solutions:
## Solution 1:
[Here is submission](https://leetcode.com/problems/median-of-two-sorted-arrays/submissions/1750279140)
> ### Runtime
> **2** ms | Beats **64.05%**

> ### Memory
> **55.94** MB | Beats **58.14%**
```csharp
public class Solution
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
```
## Solution 2:
[Here is submission](https://leetcode.com/problems/median-of-two-sorted-arrays/submissions/1750284966)
> ### Runtime
> **20** ms | Beats **10.04%**

> ### Memory
> **56.21** MB | Beats **39.11%**
```csharp
public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var merged = nums1.Concat(nums2).ToArray();
        Array.Sort(merged);

        if (merged.Length % 2 == 1)
        {
            return merged[merged.Length / 2];
        }
        
        return (merged[merged.Length / 2 - 1] + merged[merged.Length / 2]) / 2.0;
    }
}
```