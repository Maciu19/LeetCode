namespace LeetCode.Singly_Linked_Lists;

// Link: https://leetcode.com/problems/reverse-linked-list/description/
public class Reverse_Linked_List
{
    static void Main(string[] args)
    {
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

        Solution solution = new Solution();
        ListNode reversedList = solution.ReverseList(head);

        while(reversedList is not null)
        {
            Console.WriteLine(reversedList.val);
            reversedList = reversedList.next;
        }
    }

    private class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode next = head;
            ListNode prev = null;

            while (next is not null)
            {
                head = next;

                next = head.next;
                head.next = prev;
                prev = head;
            }

            return head;
        }
    }
}
