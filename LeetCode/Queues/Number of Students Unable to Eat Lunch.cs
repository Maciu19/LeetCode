namespace LeetCode.Queues;

// Link: https://leetcode.com/problems/number-of-students-unable-to-eat-lunch/
public class Number_of_Students_Unable_to_Eat_Lunch
{
    static void Main(string[] args)
    {
        Solution solution = new();

        // Example 1
        int[] students1 = [1, 1, 0, 0];
        int[] sandwiches1 = [0, 1, 0, 1];
        Console.WriteLine(solution.CountStudents(students1, sandwiches1));

        // Example 2
        int[] students2 = [1, 1, 1, 0, 0, 1];
        int[] sandwiches2 = [1, 0, 0, 0, 1, 1];
        Console.WriteLine(solution.CountStudents(students2, sandwiches2));

        // Example 3
        int[] students3 = [0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1];
        int[] sandwiches3 = [1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 1, 1, 0];
        Console.WriteLine(solution.CountStudents(students3, sandwiches3));
    }

    private class Solution
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            int index = 0;

            int sandwichesLength = sandwiches.Length;
            int studentsLength = students.Length;

            while (sandwichesLength > 0 && studentsLength > 0)
            {
                int firstSandwich = sandwiches[0];
                if (!ContainsElementWithinLength(students, studentsLength, firstSandwich))
                {
                    break;
                }

                if (sandwiches[index] == students[index])
                {
                    RemoveFirstElement(students);
                    RemoveFirstElement(sandwiches);

                    studentsLength--;
                    sandwichesLength--;
                }
                else
                {
                    int value = students[index];
                    RemoveFirstElement(students);
                    students[studentsLength - 1] = value;
                }
            }

            return studentsLength;
        }

        private void RemoveFirstElement(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
        }

        private bool ContainsElementWithinLength(int[] array, int length, int element)
        {
            for (int i = 0; i < length; i++)
            {
                if (array[i] == element)
                    return true;
            }

            return false;
        }
    }
}
