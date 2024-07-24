namespace LeetCode.Queues;

// Link: https://leetcode.com/problems/implement-stack-using-queues/description/
public class Implement_Stack_using_Queues
{
    static void Main(string[] args)
    {
        // Example 1
        MyStack example1 = new();
        example1.Push(1);
        example1.Push(2);
        Console.WriteLine(example1.Top());
        Console.WriteLine(example1.Pop());
        Console.WriteLine(example1.Empty());
    }

    private class MyStack
    {
        public Queue<int> Queue { get; set; }
        public Queue<int> Reversed { get; set; }

        public MyStack()
        {
            Queue = new Queue<int>();
            Reversed = new Queue<int>();
        }

        public void Push(int x)
        {
            Queue.Enqueue(x);
            Reversed = ReverseQueue(Queue);
        }

        public int Pop()
        {
            int popValue = Reversed.Dequeue();
            Queue = ReverseQueue(Reversed);
                
            return popValue;
        }

        public int Top()
        {
            return Reversed.Peek();
        }

        public bool Empty()
        {
            if (Queue.Count == 0)
                return true;

            return false;
        }

        private static Queue<int> ReverseQueue(Queue<int> normal)
        {
            Queue<int> reversed = new Queue<int>();

            IEnumerable<int> reversedItems = normal.Reverse();

            foreach (int x in reversedItems)
            {
                reversed.Enqueue(x);
            }

            return reversed;
        }
    }
}
