# 1. Two Sum

![Easy](https://img.shields.io/badge/-Easy-00af9b?style=flat)

Given an array of integers `nums` and an integer `target`, return *indices of the two numbers such that they add up to `target`.*

You may assume that each input would have ***exactly* one solution**, and you may not use the *same* element twice.

You can return the answer in any order.

**Example 1:**

> **Input:** nums = [2,7,11,15], target = 9 \
> **Output:** [0,1] \
> **Explanation:** Because nums[0] + nums[1] == 9, we return [0, 1].

**Example 2:**

> **Input:** nums = [3,2,4], target = 6 \
> **Output:** [1,2] 

**Example 3:**

> **Input:** nums = [3,3], target = 6 \
> **Output:** [0,1]


Constraints:

* `2 <= nums.length <= 10^4`
* `-10^9 <= nums[i] <= 10^9`
* `-10^9 <= target <= 10^9`
* **Only one valid answer exists.**


**Follow-up:** Can you come up with an algorithm that is less than `O(n2)` time complexity?

---

# Solutions:

## Solution 1:
[Here is submission](https://leetcode.com/problems/two-sum/submissions/1750213224)
> ### Runtime
> **29** ms | Beats **47.01%** 

> ### Memory
> **48.57** MB | Beats **75.71%**

```csharp
public class Solution 
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
```

## Solution 2:
[Here is submission](https://leetcode.com/problems/two-sum/submissions/1750213224)
> ### Runtime
> **1** ms | Beats **98.92%**

> ### Memory
> **48.99** MB | Beats **43.97%**

```csharp
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>(nums.Length);
        
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
```