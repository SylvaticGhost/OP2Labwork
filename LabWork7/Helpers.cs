namespace LabWork7;

public static class Helpers
{
    public static void ValidateArray(ref double[] array)
    {
        if (array.Any(double.IsNaN))
            throw new ArgumentException("The array contains NaN, that can't be compared for sorting");
    }
    
    
    public static void WriteCollection<T>(IEnumerable<T> list)
    {
        foreach (T o in list)
        {
            Console.Write(o + " ");
        }

        Console.WriteLine();
    }
    
    
    public static double[] GenerateArray(int size)
    {
        double[] array = new double[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = Math.Round(new Random().NextDouble(), 3) ;
        }

        return array;
    }
    
    
    public static void WriteTitle(string title)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(title);
        Console.ResetColor();
        Console.WriteLine();
    }
}