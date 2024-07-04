using LeetCode.Helpers;

namespace LeetCode.Static_Array;

// Link: https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
public class Remove_Duplicates_From_Sorted_Array
{
    // in-place algorithm = it modifies the input in place, without creating a separate copy of the data structure
    // Two-pointers approach = allow us to keep track simultaneously, of two elements inside a given array,
    //allowing us to process two elements per iteration, instead of one. 
    // Common approache for two-pointers:
    //  - One pointer move at slow peace while the other pointer move a faster peace
    //  - One pointer starts from the begining while the other pointer starts from the end until they both meet.
    static void Main(string[] args)
    {
        // Example 1
        int[] nums1 = [1, 1, 2];
        Console.WriteLine($"Unique elements: {RemoveDuplicates(nums1)}");
        ArrayHelper.PrintArray(nums1);

        // Example 2
        int[] nums2 = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        Console.WriteLine($"Unique elements: {RemoveDuplicates(nums2)}");
        ArrayHelper.PrintArray(nums2);
    }

    public static int RemoveDuplicates(int[] nums)
    {
        int i = 0;

        if (nums.Length == 1)
            return i + 1;

        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[j] != nums[i])
            {
                i++;
                nums[i] = nums[j];
            }
        }

        return i + 1;
    }

    // Weak implementation because I didn't undertand the description. 
    //I thought that "_" represents a unintialized space of memory and I shoudn't modify the 
    //size of the array.
    public static int RemoveDuplicatesV2(int[] nums)
    {
        int numberOfUniqueValues = 1;
        int index1 = 0;
        int index2 = 1;

        if (nums.Length == 1)
            return numberOfUniqueValues;

        while(index2 < nums.Length)
        {
            if (nums[index1] > nums[index2])
                break;

            if (nums[index1] == nums[index2])
            {
                for(int i = index2 + 1; i < nums.Length; i++)
                {
                    nums[i - 1] = nums[i];
                }
                nums[nums.Length - 1] = -int.MaxValue;
            }
            else
            {
                index1++;
                index2++;
                numberOfUniqueValues++;
            }
        }

        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == -int.MaxValue)
                nums[i] = default;
        }

        return numberOfUniqueValues;
    }
}
