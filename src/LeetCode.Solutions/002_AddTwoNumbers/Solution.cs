using LeetCode.Solutions._002_AddTwoNumbers.Adds;

namespace LeetCode.Solutions._002_AddTwoNumbers;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
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