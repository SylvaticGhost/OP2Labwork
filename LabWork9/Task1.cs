namespace LabWork9;

public class Task1
{
    public static void Main()
    {
        Console.WriteLine("Task 1");
        int[] testCases = [0, 1, 10, 15, 16, 255, 256, 1024, 4096, 51966, 65535, 65536];
        
        foreach (int testCase in testCases)
        {
            Console.WriteLine($"Int: {testCase}");
            Console.WriteLine($"Hex: {IntToHexString(testCase)}\n");
        }
    }

    public static string IntToHexString(int number)
    {
        if (number < 0)
            throw new ArgumentException("Argument must be greater than or equal to 0", nameof(number));
        
        string result = string.Empty;
        
        if (number == 0)
            return "0";
        
        while (number > 0)
        {
            int remainder = number % 16;
            result = remainder < 10 ? remainder + result : (char)('A' + remainder - 10) + result;
            number /= 16;
        }
        
        return result;
    }
}