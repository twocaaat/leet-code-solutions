namespace LeetCode.Solutions._003_LongestSubstringWithoutRepeatingCharacters;

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