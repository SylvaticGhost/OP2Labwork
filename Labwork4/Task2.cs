namespace Labwork4;

public class Task2 //55
{
    public static void Main()
    {
        int k = 4;

        Console.WriteLine("Starting Task 2");

        List<double[]> testCases = [];

        for (int i = 1; i < 14; i += 2)
        {
            double[] array = Helpers.GenerateArray<double>(i);

            testCases.Add(array);
        }

        foreach (double[] array in testCases)
        {
            try
            {
                Console.WriteLine("Array: ");
                Helpers.PrintArray(array);
                Console.WriteLine(
                    $"Number of elements aliquot to {k}: {CalculateNumOfElementsWithWithAliquot(array, k)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Got an exception" + ex.Message);
            }
        }
    }

    private static int CalculateNumOfElementsWithWithAliquot(IReadOnlyList<double> array, int aliquotK) =>
            array.Count / aliquotK + 1; 
}