namespace LeetCode.Dynamic_Array;

// Link: https://leetcode.com/problems/concatenation-of-array/description/
public class Concatenation_Of_Array
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 1 };
        int[] result = GetConcatenation(nums);

        foreach (var item in result)
        {
            Console.Write(item + " ");
        }
    }

    public static int[] GetConcatenation(int[] nums)
    {
        int numsLength = nums.Length;
        int[] result = new int[numsLength * 2];

        for (int i = 0; i < result.Length; i++)
        {
            if (i < numsLength)
            {
                result[i] = nums[i];
            }
            else
            {
                result[i] = nums[i - numsLength];
            }
        }

        return result;
    }

    public static int[] GetConcatenationV2(int[] nums)
    {
        return nums.Concat(nums).ToArray();
    }
}
