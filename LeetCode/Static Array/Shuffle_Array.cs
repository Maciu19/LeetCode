using LeetCode.Helpers;

namespace LeetCode.Static_Array;

// Link: https://leetcode.com/problems/shuffle-the-array/description/
public class Shuffle_Array
{
    static void Main(string[] args)
    {
        // Example 1
        int[] nums1 = [2, 5, 1, 3, 4, 7];
        int n1 = 3;
        ArrayHelper.PrintArray(Shuffle(nums1, n1));

        // Example 2
        int[] nums2 = [1, 2, 3, 4, 4, 3, 2, 1];
        int n2 = 4;
        ArrayHelper.PrintArray(Shuffle(nums2, n2));

        // Example 3
        int[] nums3 = [1, 1, 2, 2];
        int n3 = 2;
        ArrayHelper.PrintArray(Shuffle(nums3, n3));

    }

    public static int[] Shuffle(int[] nums, int n)
    {
        int[] x_array = new int[n];
        int x_arr_index = 0;

        int[] y_array = new int[n];
        int y_arr_index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i < n)
            {
                x_array[x_arr_index] = nums[i];
                x_arr_index++;
            }
            else
            {
                y_array[y_arr_index] = nums[i];
                y_arr_index++;
            }
        }

        x_arr_index = 0;
        y_arr_index = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0)
            {
                nums[i] = x_array[x_arr_index];
                x_arr_index++;
            }
            else
            {
                nums[i] = y_array[y_arr_index];
                y_arr_index++;
            }
        }

        return nums;
    }
}
