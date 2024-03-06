using static System.Double;

namespace Labwork4;

public static class Task1 //25
{
    public static void Main()
    {
        Console.WriteLine("Starting Task 1");

        List<double[]> testCases = [];
        
        for (int i = 1; i < 7; i += 2)
        {
            double[] array = Helpers.GenerateArray<double>(i);
            
            testCases.Add(array);
        }
        
        testCases.Add(new [] {NaN, -Pi, E});
        
        foreach (double[] array in testCases)
        {
            try
            {
                Console.WriteLine("Array: ");
                Helpers.PrintArray(array);
                Console.WriteLine("Second min on module: " + FindSecondMinOnModuleElement(array));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Got an exception" + ex.Message);
            }
        }
    }
    
    
    private static double FindSecondMinOnModuleElement(IReadOnlyList<double> array)
    {
        if(array.Count < 2)
            throw new ArgumentException("Array length must be at least 2");

        double min, secondMin;
        
        double[] forbiddenValues = [NaN];
        
        if(array.Any(i => forbiddenValues.Contains(i)))
            throw new ArgumentException("Array contains forbidden values");
        
        if(Math.Abs(array[0]) < Math.Abs(array[1]))
        {
            min = array[0];
            secondMin = array[1];
        }
        else
        {
            min = array[1];
            secondMin = array[0];
        }
        
        for (int i = 2; i < array.Count; i++)
        {
            if (Math.Abs(array[i]) < Math.Abs(min))
            {
                secondMin = min;
                min = array[i];
            }
            else if (Math.Abs(array[i]) < Math.Abs(secondMin))
            {
                secondMin = array[i];
            }
        }
        
        return secondMin;
    }
}