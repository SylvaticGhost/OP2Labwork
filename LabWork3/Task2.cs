namespace LabWork3;

public static class Task2 //9
{
    public static void Main()
    {
        Console.WriteLine("Starting Task#2");

        //pair l, t
        IReadOnlyList<(double, uint)> testCases = [(56, 30),
            (2, 35),
            (3, 40),
            (4, 45),
            (5, 50),
            (double.MaxValue, 140),
            (double.MinValue, 100),
            (double.NaN, 200),
            (double.NegativeInfinity, 100),
            (double.PositiveInfinity, 187),
        (4560.08, 87)];
        
        foreach (var (l, t) in testCases)
        {
            try
            {
                double result = CalculateSum(l, t);
                Console.WriteLine($"Values: l = {l}, t = {t}, result = {result}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Handled an Argument out of range exception, " + ex.Message);
                Console.ResetColor();
            }
        }

        Console.WriteLine(CalculateSum(2, 35));
    }


    /// <summary>
    /// Calculate sum for x(t, l)
    /// </summary>
    /// <param name="l">user passed parameter</param>
    /// <param name="t">limit of iterions in sum</param>
    /// <returns>a result of sum operation</returns>
    private static double CalculateSum(double l, uint t)
    {
        if (double.IsNaN(l) || double.IsInfinity(l))
            throw new ArgumentOutOfRangeException(nameof(l), "Exception in task #2, l is NaN or infinity");
        
        if(t == 0)
            throw new ArgumentOutOfRangeException(nameof(t), "Exception in task #2, t is zero");

        double sum = 0;

        for (uint i = 0; i < t; i++)
        {
            double localDecrement = i % 2 == 1 ? F1(t, i) : F2(t, i);

            if ((Int128)(sum + localDecrement) > (Int128)double.MaxValue)
                throw new ArgumentOutOfRangeException(nameof(sum), "Exception in task #2, the sum is out of range");

            sum += localDecrement;
        }

        return sum;
    }


    private static double F1(uint t, double l) => Math.Sqrt(t * l);


    private static double F2(uint t, double l) => l / Math.Sqrt(t);
}
