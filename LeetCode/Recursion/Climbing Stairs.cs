namespace LeetCode.Recursion;

public class Climbing_Stairs
{
    static void Main(string[] args)
    {
        Solution s = new();

        Console.WriteLine(s.ClimbStairs(2));
        Console.WriteLine(s.ClimbStairs(3));
        Console.WriteLine(s.ClimbStairs(4));
    }

    private class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n <= 3)
            {
                return n;
            }

            return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }
    }
}
