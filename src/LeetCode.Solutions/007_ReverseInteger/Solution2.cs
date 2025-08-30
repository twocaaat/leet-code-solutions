namespace LeetCode.Solutions._007_ReverseInteger;

public class Solution2
{
    public int Reverse(int x)
    {
        if (x <= int.MinValue)
        {
            return 0;
        }
         
        Int64 reversedX = 0;
        var sign = 1;
        
        if (x < 0)
        {
            sign = -1;
            x = -x;
        }

        while (x != 0)
        {
            reversedX *= 10;
            reversedX += x % 10;

            if (reversedX > int.MaxValue)
            {
                return 0;
            }
            
            x /= 10;
        }
        
        return (int)reversedX * sign;
    }
}