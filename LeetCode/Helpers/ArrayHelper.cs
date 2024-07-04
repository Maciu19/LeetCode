namespace LeetCode.Helpers;

public static class ArrayHelper
{
    public static void PrintArray(int[] nums)
    {
        foreach (var num in nums)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}
