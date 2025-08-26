# 2. Add Two Numbers

***Medium***

You are given two **non-empty** linked lists representing two non-negative integers. The digits are stored in **reverse order**, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

**Example 1:**

> Input: l1 = [2,4,3], l2 = [5,6,4] \
> Output: [7,0,8] \
> Explanation: 342 + 465 = 807.

**Example 2:**

> Input: l1 = [0], l2 = [0] \
> Output: [0] 

**Example 3:**

> Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9] \
> Output: [8,9,9,9,0,0,0,1]

**Constraints:**

* The number of nodes in each linked list is in the range `[1, 100]`.
* `0 <= Node.val <= 9`
* It is guaranteed that the list represents a number that does not have leading zeros.

---

# Solutions:
## Solution 1:
> ### Runtime
> **1** ms | Beats **92.36%**

> ### Memory
> **53.76** MB | Beats **72.33%**
```csharp
public class Solution
{
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var rest = 0;
        ListNode? head = null;
        ListNode? tail = null;
        
        while (l1 != null || l2 != null || rest != 0)
        {
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + rest;
            rest = 0;
            
            if (sum >= 10)
            {
                rest = 1;
                sum -= 10;
            }
            
            if (head == null)
            {
                head = new ListNode(sum);
                tail = head;
            }
            else
            {
                var node = new ListNode(sum);
                tail!.next = node;
                tail = node;
            }
            
            l1 = l1?.next;
            l2 = l2?.next;
        }
        
        return head ?? new ListNode();
    }
}
```