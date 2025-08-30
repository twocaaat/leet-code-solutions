namespace LeetCode.Solutions._007_ReverseInteger;

public class Solution1
{
    public int Reverse(int x)
    {
        var reversedX = 0;
        var sign = 1;
        
        if (x < 0)
        {
            sign = -1;
            x = -x;
        }

        while (x != 0)
        {
            try
            {
                checked
                {
                    reversedX *= 10;
                    reversedX += x % 10;
                }
            }
            catch (OverflowException)
            {
                return 0;
            }
            
            x /= 10;
        }
        
        return reversedX * sign;
    }
}