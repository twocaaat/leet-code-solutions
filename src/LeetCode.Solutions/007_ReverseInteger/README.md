# 7. Reverse Integer

![Medium](https://img.shields.io/badge/-Medium-ffb800?style=flat)


Given a signed 32-bit integer `x`, return `x` with its digits reversed. If reversing `x` causes the value to go outside the signed 32-bit integer range `[-23^1, 2^31 - 1]`, then return `0`.

**Assume the environment does not allow you to store 64-bit integers (signed or unsigned).**

**Example 1:**

> **Input:** x = 123 \
> **Output:** 321 

**Example 2:**

> **Input:** x = -123 \
> **Output:** -321 

**Example 3:**

> **Input:** x = 120 \
> **Output:** 21 

**Constraints:**

* `-2^31 <= x <= 2^31 - 1`

---

# Solutions:
## Solution 1:
[Here is submission](https://leetcode.com/problems/reverse-integer/submissions/1753816381)
> ### Runtime
> **28** ms | Beats **40.65%**

> ### Memory
> **30.20** MB | Beats **18.39%**
```csharp
public class Solution
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
```

## Solution 2:
[Here is submission](https://leetcode.com/problems/reverse-integer/submissions/1753826406)
> ### Runtime
> **21** ms | Beats **84.05%**

> ### Memory
> **28.60** MB | Beats **97.53%**
```csharp
public class Solution
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
```