namespace LeetCode.Singly_Linked_Lists;

public class Merge_Two_Sorted_Lists
{
    static void Main(string[] args)
    {
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

        Solution solution = new Solution();
        ListNode mergedList = solution.MergeTwoLists(list1, list2);

        while (mergedList is not null)
        {
            Console.WriteLine(mergedList.val);
            mergedList = mergedList.next;
        }
    }

    private class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode tail = dummy;

            while (list1 is not null && list2 is not null)
            {
                if (list1.val < list2.val)
                {
                    tail.next = list1;

                    list1 = list1.next;
                }
                else if (list1.val >= list2.val)
                {
                    tail.next = list2;

                    list2 = list2.next;
                }

                tail = tail.next;
            }

            while(list1 is not null)
            {
                tail.next = list1;
                list1 = list1.next;
                tail = tail.next;
            }

            while(list2 is not null)
            {
                tail.next = list2;
                list2 = list2.next;
                tail = tail.next;
            }

            return dummy.next;
        }
    }
}


