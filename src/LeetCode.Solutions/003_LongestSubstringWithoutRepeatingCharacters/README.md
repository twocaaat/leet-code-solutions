# 3. Longest Substring Without Repeating Characters

![Medium](https://img.shields.io/badge/-Medium-ffb800?style=flat)

Given a string `s`, find the length of the **longest substring** without duplicate characters.

**Example 1:**

> **Input:** s = "abcabcbb" \
> **Output:** 3 \
> **Explanation:** The answer is "abc", with the length of 3.

**Example 2:**

> **Input:** s = "bbbbb" \
> **Output:** 1 \
> **Explanation:** The answer is "b", with the length of 1.

**Example 3:**

> **Input:** s = "pwwkew" \
> **Output:** 3 \
> **Explanation:** The answer is "wke", with the length of 3. \
> Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

**Constraints:**

* `0 <= s.length <= 5 * 10^4`
* `s` consists of English letters, digits, symbols and spaces.

---

# Solutions:
## Solution 1:
[Here is submission](https://leetcode.com/problems/longest-substring-without-repeating-characters/submissions/1749256964)
> ### Runtime
> **29** ms | Beats **24.34%**

> ### Memory
> **43.70** MB | Beats **82.59%**
```csharp
public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        var hasSet = new HashSet<char>();
        var maxSubstringLength = 0;
        
        for(var i = 0; i < s.Length; i++)
        {
            var seqSize = 0;
            for (var j = i; j < s.Length; j++)
            {
                if (!hasSet.Add(s[j]))
                {
                    break;
                }
                
                seqSize++;
            }
            
            maxSubstringLength = Math.Max(maxSubstringLength, seqSize);
            hasSet.Clear();
        }
        
        return maxSubstringLength;
    }
}
```