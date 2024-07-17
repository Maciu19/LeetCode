namespace LeetCode.Stacks;

// Link: https://leetcode.com/problems/min-stack/
public class Min_Stack
{
    static void Main()
    {
        MinStack exampleMinStack = new MinStack();
        exampleMinStack.Push(-2);
        exampleMinStack.Push(0);
        exampleMinStack.Push(-3);
        Console.WriteLine(exampleMinStack.GetMin()); // return -3
        exampleMinStack.Pop();
        Console.WriteLine(exampleMinStack.Top()); // return 0
        Console.WriteLine(exampleMinStack.GetMin()); // return -2
    }
}

public class MinStack
{
    private readonly List<int> _stack;
    private readonly Stack<int> _minim;

    public MinStack()
    {
        _stack = [];
        _minim = new Stack<int>();
    }

    public void Push(int val)
    {
        _stack.Add(val);

        if(_minim.Count == 0)
        {
            _minim.Push(val);
        }
        else if (_minim.Peek() >= val)
        {
            _minim.Push(val);
        }
    }

    public void Pop()
    {
        if (_stack[_stack.Count - 1] == _minim.Peek())
        {
            _minim.Pop();
        }

        _stack.RemoveAt(_stack.Count - 1);
    }

    public int Top()
    {
        return _stack[_stack.Count - 1];
    }

    public int GetMin()
    {
        return _minim.Peek();
    }
}
