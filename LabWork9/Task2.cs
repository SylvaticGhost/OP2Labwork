using System.Text;
using System.Text.RegularExpressions;

namespace LabWork9;

public class Task2
{
    public static void Main()
    {
        Console.WriteLine("Task 2");
        string[] testCases = [
            """
            The user with the nickname koala757677 this month wrote 3 times more
                            comments than the user with the nickname croco181dile920 4 months ago
            """,
            "Hello, World",
            "Fix the 11 Bugs"
        ];
        
        foreach (string testCase in testCases)
        {
            Console.WriteLine("string: \n" + testCase);
            Console.WriteLine("lowercase: ");
            Console.WriteLine(ChangeToLowerCase(testCase) + "\n");
        }
    }


    public static string ChangeToLowerCase(string str)
    {
        if (string.IsNullOrEmpty(str))
            throw new ArgumentNullException(nameof(str), "Argument must not be null or empty");
        
        if (!Regex.IsMatch(str,@"^[a-zA-Z0-9\s,\.]*$"))
            throw new ArgumentException("Argument must contain only letters, digits and whitespaces", nameof(str));
        
        
        string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder result = new StringBuilder();
        
        foreach (string word in words)
        {
            result.Append(Regex.IsMatch(word, @"^[a-zA-Z]+$") ? word.ToLower() : word);

            result.Append(' ');
        }
        return result.ToString().Trim();
    }
}