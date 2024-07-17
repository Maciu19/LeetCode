namespace LeetCode.Stacks;

// Link: https://leetcode.com/problems/baseball-game/description/
public class Baseball_Game
{
    static void Main(string[] args)
    {
        string[] example1 = ["5", "2", "C", "D", "+"];
        Console.WriteLine(CalPoints(example1));

        string[] example2 = ["5", "-2", "4", "C", "D", "9", "+", "+"];
        Console.WriteLine(CalPoints(example2));

        string[] example3 = ["1", "C"];
        Console.WriteLine(CalPoints(example3));
    }

    public static int CalPoints(string[] operations)
    {
        Stack<int> result = new Stack<int>();

        foreach (string operation in operations)
        {
            if (operation.Equals("+"))
            {
                var prev1Element = result.Pop();
                var prev2Element = result.Peek();

                result.Push(prev1Element);
                result.Push(prev1Element + prev2Element);
            }
            else if (operation.Equals("D"))
            {
                result.Push(result.Peek() * 2);
            }
            else if(operation.Equals("C"))
            {
                result.Pop();
            }
            else
            {
                result.Push(int.Parse(operation));
            }
        }

        int sum = 0;
        while(result.Count > 0)
        {
            int value = result.Pop();
            sum += value;
        }

        return sum;
    }
}
