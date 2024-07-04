using LeetCode.Helpers;

namespace LeetCode.Static_Array;

// Link: https://leetcode.com/problems/remove-element/description/
public class Remove_Element
{
    static void Main(string[] args)
    {
        // Example 1
        int[] nums1 = [3, 2, 2, 3];
        int val1 = 3;
        Console.WriteLine($"Unique elements: {RemoveElement(nums1, val1)}");
        ArrayHelper.PrintArray(nums1);

        // Example 2
        int[] nums2 = [0, 1, 2, 2, 3, 0, 4, 2];
        int val2 = 2;
        Console.WriteLine($"Unique elements: {RemoveElement(nums2, val2)}");
        ArrayHelper.PrintArray(nums2);

        // Example 3
        int[] nums3 = [2];
        int val3 = 3;   
        Console.WriteLine($"Unique elements: {RemoveElement(nums3, val3)}");
        ArrayHelper.PrintArray(nums3);

        // Example 4
        int[] nums4 = [3, 3];
        int val4 = 3;
        Console.WriteLine($"Unique elements: {RemoveElement(nums4, val4)}");
        ArrayHelper.PrintArray(nums4);
    }

    public static int RemoveElement(int[] nums, int val)
    {
        int i, j = 0;
        for(i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[j] = nums[i];
                j++;
            }
        }

        return j;
    }
}
