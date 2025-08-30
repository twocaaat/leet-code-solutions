namespace LeetCode.Solutions._006_ZigzagConversion;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }

        var resultIndex = 0;
        Span<char> result = stackalloc char[s.Length];
        // var result = new StringBuilder();
        var period = numRows * 2 - 2;

        for (var row = 0; row < numRows; row++)
        {
            var increment = row * 2;

            for (var i = row; i < s.Length; i += increment)
            {
                // result.Append(s[i]);
                result[resultIndex++] = s[i];
                
                if (increment != period)
                {
                    increment = period - increment;
                }
            }
        }
        
        return result.ToString();
    }
}