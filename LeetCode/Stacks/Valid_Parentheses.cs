namespace LeetCode.Stacks;

// Link: https://leetcode.com/problems/valid-parentheses/
public class Valid_Parentheses
{
    static void Main(string[] args)
    {
        string s1 = "()";
        Console.WriteLine(IsValid(s1));

        string s2 = "()[]{}";
        Console.WriteLine(IsValid(s2));

        string s3 = "(]";
        Console.WriteLine(IsValid(s3));

        string s4 = "{[]}";
        Console.WriteLine(IsValid(s4));
    }

    public static bool IsValid(string s)
    {
        Stack<char> result = new();

        foreach (char character in s)
        {
            if (character.Equals('(') || character.Equals('[') || character.Equals('{'))
            {
                result.Push(character);
                continue;
            }

            if (result.Count > 0)
            {
                if (character.Equals(')') && !result.Pop().Equals('('))
                    return false;

                if (character.Equals(']') && !result.Pop().Equals('['))
                    return false;

                if (character.Equals('}') && !result.Pop().Equals('{'))
                    return false;
            }
            else
            {
                return false;
            }

        }

        if (result.Count != 0)
            return false;

        return true;
    }
}
