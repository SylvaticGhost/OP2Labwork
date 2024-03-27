
using LabWork6;


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Testing the buble sort");
Console.ResetColor();

IReadOnlyList<double[]> testCases1 = Helpers.CreateTestCases(16);

foreach (double[] test in testCases1)
{
    try
    {
        var array = test;

        Console.WriteLine("Generated array:");
        Helpers.WriteCollection(array);

        SortAlgorithms.BubbleSort(ref array);

        Console.WriteLine("Sorted:");
        Helpers.WriteCollection(array);
    }
    catch(ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }

    Console.WriteLine();
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Testing the selection sort");
Console.ResetColor();
Console.WriteLine();

IReadOnlyList<double[]> testCases2 = Helpers.CreateTestCases(16);

foreach (double[] test in testCases2)
{
    try
    {
        var array = test;

        Console.WriteLine("Generated array:");
        Helpers.WriteCollection(array);

        SortAlgorithms.SelectionSort(ref array);

        Console.WriteLine("Sorted:");
        Helpers.WriteCollection(array);
    }
    catch(ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }

    Console.WriteLine();
}




