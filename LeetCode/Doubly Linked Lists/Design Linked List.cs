namespace LeetCode.Doubly_Linked_Lists;

public class Design_Linked_List
{
    static void Main(string[] args)
    {
        // Example 1
        MyLinkedList myLinkedList = new MyLinkedList();
        myLinkedList.AddAtHead(1);
        myLinkedList.AddAtTail(3);
        myLinkedList.AddAtIndex(1, 2);          // linked list becomes 1->2->3
        Console.WriteLine(myLinkedList.Get(1)); // return 2
        myLinkedList.DeleteAtIndex(1);          // now the linked list is 1->3
        Console.WriteLine(myLinkedList.Get(1)); // return 3
        Console.WriteLine();

        // Example 2
        MyLinkedList myLinkedList2 = new MyLinkedList();
        myLinkedList2.AddAtHead(7);
        myLinkedList2.AddAtHead(2);
        myLinkedList2.AddAtHead(1);
        myLinkedList2.AddAtIndex(3, 0);
        myLinkedList2.DeleteAtIndex(2);
        myLinkedList2.AddAtHead(6);
        myLinkedList2.AddAtTail(4);
        Console.WriteLine(myLinkedList2.Get(4));
        myLinkedList2.AddAtHead(4);
        myLinkedList2.AddAtIndex(5, 0);
        myLinkedList2.AddAtHead(6);
        Console.WriteLine();

        // Example 3
        MyLinkedList myLinkedList3 = new MyLinkedList();
        myLinkedList3.AddAtHead(1);
        myLinkedList3.AddAtTail(3);
        myLinkedList3.AddAtIndex(1, 2);
        Console.WriteLine(myLinkedList3.Get(1));
        myLinkedList3.DeleteAtIndex(0);
        Console.WriteLine(myLinkedList3.Get(0));

        // Example 4
        MyLinkedList myLinkedList4 = new MyLinkedList();
        myLinkedList4.AddAtHead(1);
        myLinkedList4.DeleteAtIndex(0);
    }

    private class Node
    {
        public Node Prev { get; set; }
        public int Val { get; set; }
        public Node Next { get; set; }

        public Node(
            Node prev = null, 
            int val = 0,
            Node next = null)
        {
            Prev = prev;
            Val = val;
            Next = next;
        }
    }

    private class MyLinkedList
    {
        private Node Head;
        private Node Tail;
        private int length;

        public MyLinkedList()
        {
            Head = Tail = null;
            length = 0;
        }

        public int Get(int index)
        {
            Node temp = Head;
            int i = 0;

            while(temp is not null)
            {
                if (i == index)
                    return temp.Val;

                temp = temp.Next;
                i++;
            }

            return -1;
        }

        public void AddAtHead(int val)
        {
            if (length == 0)
            {
                Head = Tail = new(null, val, null);
                length++;
                return;
            }

            Node newNode = new(null, val, Head);
            Head.Prev = newNode;
            Head = newNode;

            length++;
        }

        public void AddAtTail(int val)
        {
            if (length == 0)
            {
                Tail = Head = new(null, val, null);
                length++;
                return;
            }

            Node newNode = new(Tail, val, null);
            Tail.Next = newNode;
            Tail = newNode;

            length++;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index > length)
                return;

            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            if (index == length)
            {
                AddAtTail(val);
                return;
            }

            Node temp = Head;
            int i = 0;

            while (temp.Next is not null)
            {
                if (i == index - 1)
                {
                    Node newNode = new(temp, val, temp.Next);
                    temp.Next.Prev = newNode;
                    temp.Next = newNode;
                }

                temp = temp.Next;
                i++;
            }

            length++;
        }

        public void DeleteAtIndex(int index)
        {
            if (index > length)
                return;

            if (length == 0)
                return;

            if (index == 0)
            {
                DeleteAtHead();
                return;
            }

            Node temp = Head;
            int i = 0;

            while (temp.Next is not null)
            {
                if (i == index - 1)
                {
                    temp.Next.Next.Prev = temp;
                    temp.Next = temp.Next.Next;
                }

                temp = temp.Next;
                i++;
            }

            length--;
        }

        private void DeleteAtHead()
        {
            if (length == 1)
            {
                Head = Tail = null;
                length--;
                return;
            }

            Head.Next.Prev = null;
            Head = Head.Next;
            length--;
        }
    }
}
