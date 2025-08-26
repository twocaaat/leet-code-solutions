namespace LeetCode.Solutions._002_AddTwoNumbers.Adds;

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
    
    
    public static ListNode? FromArray(int[]? values)
    {
        if (values == null || values.Length == 0)
            return null;

        var head = new ListNode(values[0]);
        var current = head;

        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }

        return head;
    }

    public int[] ToArray()
    {
        var list = new List<int>();
        var current = this;

        while (current != null)
        {
            list.Add(current.val);
            current = current.next;
        }

        return list.ToArray();
    }
}