namespace LabWork3;

public static class Task3 // 13
{
    public static void Main()
    {
        IReadOnlyList<double> testCases = [0.00001, 0000001, 0.000000001, 0.0000000000023, double.NegativeInfinity, 0];

        foreach (double epsilon in testCases)
        {
            try
            {
                double result = CalculateSum(epsilon);

                Console.WriteLine($"epsilon = {epsilon}, result = {result}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Handled an argument out of range exception, " + ex.Message);
                Console.ResetColor();
            }
        }

    }


    private static double CalculateSum(double epsilon)
    {
        if (double.IsNaN(epsilon) || double.IsInfinity(epsilon) || epsilon <= 0)
            throw new ArgumentOutOfRangeException(nameof(epsilon), "Exception in task #3, l is NaN or infinity or not bigger than zero");

        int i = 1;
        double sum = 0;
        Int64 factResult = 1;


        while (true)
        {
            factResult *= i;
            double decrement = Math.Pow(-1, i) / factResult;

            if(Math.Abs(decrement) < epsilon)
                break;

            sum += decrement;
            i++;
        }
        return sum;
    }
}