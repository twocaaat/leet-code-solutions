namespace LeetCode.Solutions._001_TwoSum;

public class Solution1 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        for (var i = 0; i < nums.Length - 1; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }
        
        throw new ArgumentException("No such two sum");
    }
}