namespace LabWork3;

public static class Task1
{
    public static void Main()
    {
        IReadOnlyList<(double, uint)> testCases = new List<(double, uint)>
        {
            (double.PositiveInfinity, 35),
            (double.MaxValue, 35),
            (3456.904, 35),
            (double.MinValue, 35),
            (double.NaN, 35),
            (456756758, 35),
            (double.NegativeInfinity, 35),
            (122131243242423.0990897, 35)
        };

        foreach (var (S, k) in testCases)
        {
            try
            {
                double result = CalculateSum(S, k);

                Console.WriteLine($"Values: S = {S}, t = {k}, result = {result}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Handled an argument out of range exception, " + ex.Message);
                Console.ResetColor();
            }
        }
    }

    private static double CalculateSum(double S, uint k)
    {
        if (double.IsNaN(S) || double.IsInfinity(S))
            throw new ArgumentOutOfRangeException(nameof(S), "Exception in task #1, l is NaN or infinity");

        double sum = 0;

        for (uint i = 1; i < k; i++)
        {
            sum += F(i, S);
        }

        if ((Int128)sum > (Int128)double.MaxValue)
            throw new ArgumentOutOfRangeException("e");

        return sum;
    }

    private static double F(uint i, double s)
    {
        return Math.Log10(Math.Sqrt(s * (1 / Math.Pow(i, 2))));
    }
}
