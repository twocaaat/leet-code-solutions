# 5. Longest Palindromic Substring

![Medium](https://img.shields.io/badge/-Medium-ffb800?style=flat)

Given a string `s`, return the _longest palindromic substring_ in `s`.

**Example 1:**

> **Input:** s = "babad" \
> **Output:**  "bab" \
> **Explanation:**  "aba" is also a valid answer.

**Example 2:**

> **Input:** s = "cbbd" \
> **Output:**  "bb" 

**Constraints:**

* `1 <= s.length <= 1000`
* `s` consist of only digits and English letters.

---

# Solutions:
## Solution 1:
[Here is submission](https://leetcode.com/problems/longest-palindromic-substring/submissions/1750322718)
> ### Runtime
> **8** ms | Beats **92.52%**

> ### Memory
> **41.98** MB | Beats **56.69%**
```csharp
public class Solution {
    public string LongestPalindrome(string s)
    {
        var palindrome = "";
        
        for (var i = 0; i < s.Length; i++)
        {
            var palindromeStarts = i;
            var palindromeEnds = i;
            var uniform = true;
            
            while (true)
            {
                var canLeft = palindromeStarts > 0;
                var canRight = palindromeEnds < s.Length - 1;
                
                if (canLeft && canRight && s[palindromeStarts - 1] == s[palindromeEnds + 1])
                {
                    palindromeStarts--;
                    palindromeEnds++;
                    uniform = false;
                    continue;
                }
                else if (uniform && canRight && s[palindromeStarts] == s[palindromeEnds + 1])
                {
                    palindromeEnds++;
                    continue;
                }
                else if (uniform && canLeft && s[palindromeStarts - 1] == s[palindromeEnds])
                {
                    palindromeStarts--;
                }
                
                break;
            }

            var newPalindromeLength = palindromeEnds - palindromeStarts + 1;
            if (newPalindromeLength > palindrome.Length)
            {
                palindrome = s.Substring(palindromeStarts, newPalindromeLength);
            }
        }
        
        return palindrome;
    }
}
```