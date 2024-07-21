namespace LeetCode.Doubly_Linked_Lists;

public class Design_Linked_List
{
    static void Main(string[] args)
    {
        // Example 1
        MyLinkedList myLinkedList = new();
        myLinkedList.AddAtHead(1);
        myLinkedList.AddAtTail(3);
        myLinkedList.AddAtIndex(1, 2);          // linked list becomes 1->2->3
        Console.WriteLine(myLinkedList.Get(1)); // return 2
        myLinkedList.DeleteAtIndex(1);          // now the linked list is 1->3
        Console.WriteLine(myLinkedList.Get(1)); // return 3
        Console.WriteLine();

        // Example 2
        MyLinkedList myLinkedList2 = new();
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
        MyLinkedList myLinkedList3 = new();
        myLinkedList3.AddAtHead(1);
        myLinkedList3.AddAtTail(3);
        myLinkedList3.AddAtIndex(1, 2);
        Console.WriteLine(myLinkedList3.Get(1));
        myLinkedList3.DeleteAtIndex(0);
        Console.WriteLine(myLinkedList3.Get(0));

        // Example 4
        MyLinkedList myLinkedList4 = new();
        myLinkedList4.AddAtHead(1);
        myLinkedList4.DeleteAtIndex(0);

        // Example 5
        MyLinkedList myLinkedList5 = new();
        myLinkedList5.AddAtHead(2);
        myLinkedList5.DeleteAtIndex(1);
        myLinkedList5.AddAtHead(2);
        myLinkedList5.AddAtHead(7);
        myLinkedList5.AddAtHead(3);
        myLinkedList5.AddAtHead(2);
        myLinkedList5.AddAtHead(5);
        myLinkedList5.AddAtTail(5);
        Console.WriteLine(myLinkedList5.Get(5));
        myLinkedList5.DeleteAtIndex(6);
        myLinkedList5.DeleteAtIndex(4);

        // Example 6
        MyLinkedList myLinkedList6 = new MyLinkedList();

        myLinkedList6.AddAtHead(24);
        Console.WriteLine(myLinkedList6.Get(1));
        myLinkedList6.AddAtTail(18);
        myLinkedList6.DeleteAtIndex(1);
        Console.WriteLine(myLinkedList6.Get(1));
        myLinkedList6.AddAtTail(30);
        Console.WriteLine(myLinkedList6.Get(2));
        myLinkedList6.DeleteAtIndex(1);
        myLinkedList6.AddAtHead(3);
        myLinkedList6.AddAtHead(3);
        myLinkedList6.AddAtHead(33);
        myLinkedList6.AddAtHead(97);
        myLinkedList6.AddAtTail(43);
        myLinkedList6.AddAtTail(12);
        myLinkedList6.AddAtTail(10);
        myLinkedList6.DeleteAtIndex(1);
        myLinkedList6.AddAtIndex(1, 56);
        myLinkedList6.AddAtHead(30);
        myLinkedList6.AddAtIndex(8, 83);
        myLinkedList6.AddAtTail(57);
        myLinkedList6.AddAtHead(74);
        Console.WriteLine(myLinkedList6.Get(5));
        myLinkedList6.AddAtHead(98);
        myLinkedList6.AddAtTail(72);
        myLinkedList6.AddAtHead(34);
        myLinkedList6.AddAtHead(61);
        Console.WriteLine(myLinkedList6.Get(6));
        myLinkedList6.AddAtHead(70);
        myLinkedList6.AddAtHead(24);
        myLinkedList6.AddAtTail(91);
        myLinkedList6.AddAtHead(99);
        myLinkedList6.AddAtTail(13);
        myLinkedList6.AddAtTail(10);
        myLinkedList6.DeleteAtIndex(17);
        myLinkedList6.AddAtTail(84);
        myLinkedList6.DeleteAtIndex(16);
        myLinkedList6.AddAtHead(73);
        myLinkedList6.AddAtTail(88);
        myLinkedList6.AddAtIndex(4, 19);
        myLinkedList6.AddAtHead(59);
        myLinkedList6.AddAtTail(41);
        myLinkedList6.AddAtHead(57);
        myLinkedList6.DeleteAtIndex(10);
        myLinkedList6.DeleteAtIndex(18);
        myLinkedList6.AddAtHead(2);
        myLinkedList6.AddAtTail(12);
        myLinkedList6.AddAtTail(25);
        myLinkedList6.AddAtHead(1);
        myLinkedList6.AddAtHead(77);
        Console.WriteLine(myLinkedList6.Get(1));
        myLinkedList6.DeleteAtIndex(7);
        myLinkedList6.AddAtHead(34);
        myLinkedList6.AddAtTail(87);
        myLinkedList6.DeleteAtIndex(13);
        myLinkedList6.AddAtTail(4);
        myLinkedList6.AddAtTail(12);
        myLinkedList6.AddAtTail(11);
        myLinkedList6.AddAtIndex(10, 92);
        myLinkedList6.AddAtIndex(21, 55);
        Console.WriteLine(myLinkedList6.Get(11));
        myLinkedList6.AddAtTail(38);
        myLinkedList6.AddAtTail(31);
        myLinkedList6.AddAtHead(45);
        myLinkedList6.AddAtTail(4);
        myLinkedList6.AddAtTail(88);
        myLinkedList6.AddAtHead(12);
        myLinkedList6.AddAtHead(22);
        myLinkedList6.AddAtTail(40);
        Console.WriteLine(myLinkedList6.Get(22));
        myLinkedList6.AddAtTail(22);
        myLinkedList6.AddAtHead(23);
        myLinkedList6.AddAtIndex(13, 96);
        myLinkedList6.AddAtIndex(24, 50);
        Console.WriteLine(myLinkedList6.Get(8));
        myLinkedList6.AddAtTail(14);
        myLinkedList6.AddAtTail(25);
        myLinkedList6.AddAtHead(53);
        myLinkedList6.AddAtTail(42);
        myLinkedList6.AddAtTail(6);
        myLinkedList6.AddAtHead(58);
        Console.WriteLine(myLinkedList6.Get(55));
        myLinkedList6.AddAtTail(55);
        myLinkedList6.AddAtTail(18);
        myLinkedList6.AddAtIndex(72, 13);
        myLinkedList6.DeleteAtIndex(13);
        myLinkedList6.AddAtHead(97);
        myLinkedList6.AddAtHead(59);
        myLinkedList6.AddAtTail(47);
        Console.WriteLine(myLinkedList6.Get(24));
        myLinkedList6.DeleteAtIndex(37);
        myLinkedList6.AddAtHead(24);
        myLinkedList6.AddAtTail(37);
        myLinkedList6.AddAtTail(26);
        myLinkedList6.AddAtHead(31);
        myLinkedList6.AddAtHead(93);
        myLinkedList6.DeleteAtIndex(66);
        Console.WriteLine(myLinkedList6.Get(11));
        myLinkedList6.AddAtHead(43);
        myLinkedList6.AddAtTail(70);
        myLinkedList6.AddAtHead(36);
        myLinkedList6.AddAtTail(31);
        myLinkedList6.AddAtTail(28);
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
            if (index > length)
                return -1;

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
                    length++;
                }

                temp = temp.Next;
                i++;
            }
        }

        public void DeleteAtIndex(int index)
        {
            if (index > length)
                return;

            if (length == 0)
                return;

            if (index == 0)
            {
                DeleteHead();
                return;
            }

            if (index == length - 1)
            {
                DeleteTail();
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
                    length--;
                }

                temp = temp.Next;
                i++;
            }
        }

        private void DeleteHead()
        {
            if (length == 1)
            {
                Head = Tail = null;
                length--;
                return;
            }

            Node newHead = Head.Next;
            newHead.Prev = null;
            Head = newHead;
            length--;
        }

        private void DeleteTail()
        {
            if (length == 1)
            {
                Tail = Head = null;
                length--;
                return;
            }

            Node newTail = Tail.Prev;
            newTail.Next = null;
            Tail = newTail;
            length--;
        }
    }
}
