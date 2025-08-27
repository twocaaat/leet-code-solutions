namespace LeetCode.Solutions._005_LongestPalindromicSubstring;

public class Solution
{
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