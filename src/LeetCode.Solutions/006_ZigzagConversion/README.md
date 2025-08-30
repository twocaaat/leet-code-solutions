# 0. Template

![Medium](https://img.shields.io/badge/-Medium-ffb800?style=flat)


The string `"PAYPALISHIRING"` is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
```
P   A   H   N 
A P L S I I G 
Y   I   R 
```

And then read line by line: `"PAHNAPLSIIGYIR"`

Write the code that will take a string and make this conversion given a number of rows:

> string convert(string s, int numRows);

**Example 1:**

> **Input:** s = "PAYPALISHIRING", numRows = 3 \
> **Output:** "PAHNAPLSIIGYIR"

**Example 2:**

> **Input:** s = "PAYPALISHIRING", numRows = 4 \
> **Output:** "PINALSIGYAHRPI" \
> **Explanation:**
> ```
> P     I    N
> A   L S  I G
> Y A   H R
> P     I
> ```

**Example 3:**

> **Input:** s = "A", numRows = 1 \
> **Output:** "A"

**Constraints:**

* `1 <= s.length <= 1000`
* `s` consists of English letters (lower-case and upper-case), `','` and `'.'`.
* `1 <= numRows <= 1000`

---

# Solutions:
## Solution 1:
[Here is submission]()
> ### Runtime
> **1** ms | Beats **99.47%**

> ### Memory
> **45.39** MB | Beats **98.95%**
```csharp
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
```