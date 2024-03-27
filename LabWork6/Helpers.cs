namespace LabWork6;

public static class Helpers
{
    public static double[] GenerateArray(int size)
    {
        double[] array = new double[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = Math.Round(new Random().NextDouble(), 3) ;
        }

        return array;
    }


    public static IReadOnlyList<double[]> CreateTestCases(int number, int steps = 3, int min = 3)
    {
        List<double[]> list = new List<double[]>();

        for (int i = min; i <= number; i += steps)
        {
            double[] array = GenerateArray(i);
            list.Add(array);
        }

        return list;
    }


    public static void WriteCollection<T>(IEnumerable<T> list)
    {
        foreach (T o in list)
        {
            Console.Write(o + " ");
        }

        Console.WriteLine();
    }
}