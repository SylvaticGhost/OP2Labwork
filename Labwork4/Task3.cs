using static System.Double;

namespace Labwork4;

public class Task3 //64
{
    public static void Main()
    {
        Console.WriteLine("Starting Task 1");

        List<int[]> testCases = [];
        
        for (int i = 1; i < 13; i += 3)
        {
            int[] array = Helpers.GenerateArray<int>(i);
            
            testCases.Add(array);
        }
        
        foreach (int[] array in testCases)
        {
            try
            {
                Console.WriteLine("Array: ");
                Helpers.PrintArray(array);
                Console.WriteLine("Changed array: ");
                Helpers.PrintArray(ModifyArray(array));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Got an exception" + ex.Message);
            }
        }
    }

    private static double[] ModifyArray(IList<int> array)
    {
        double[] result = new double[array.Count];
        
        for(int i = 0; i < array.Count; i++)
        {
            if (array[i] < 0)
                result[i] = array[i] * (-1);
            else if (array[i] == 0)
                result[i] = -2;
            else
                result[i] = array[i] - 3;
        }

        return result;
    }
}