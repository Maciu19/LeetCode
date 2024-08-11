using LeetCode.Singly_Linked_Lists;

namespace LeetCode.Recursion;

public class Reverse_Linked_List_Recursive
{
    private class Solution
    {
        private ListNode _reversedHead;

        public ListNode ReverseList(ListNode head)
        {
            ReversedListHelp(head);
            return _reversedHead;
        }

        private ListNode ReversedListHelp(ListNode node)
        {
            if (node is null)
                return null;

            if (node.next is null)
            {
                _reversedHead = node;
                return node;
            }

            ListNode curr = ReversedListHelp(node.next);
            curr.next = node;
            node.next = null;

            return node;
        }
    }
}
