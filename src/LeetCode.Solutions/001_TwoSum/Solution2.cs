namespace LeetCode.Solutions._001_TwoSum;

public class Solution2
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) 
        {
            dictionary[nums[i]] = i;
        }
        
        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            
            if (dictionary.ContainsKey(complement) && dictionary[complement] != i)
            {
                return [i, dictionary[complement]];
            }
        }
        
        throw new ArgumentException("No such two sum");
    }
}