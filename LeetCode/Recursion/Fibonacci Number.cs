namespace LeetCode.Recursion;

public class Fibonacci_Number
{
    static void Main(string[] args)
    {
        Solution s = new();

        Console.WriteLine(s.Fib(2));   
        Console.WriteLine(s.Fib(3));   
        Console.WriteLine(s.Fib(4));   
    }

    private class Solution
    {
        public int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
