namespace Labwork5;

public static class Task1 //1
{
    public static void Main()
    {
        Console.WriteLine("Task #1\n");
 

        for (int i = 3; i < 10; i += 2)
        {
            try
            {
                int[][] matrix = Helpers.GenerateMatrix(i, i);
                Console.WriteLine($"Matrix {i}x{i}:");
                Helpers.PrintMatrix(matrix);
                Console.WriteLine($"Min element in largest column: {MinElementInLargestColumn(matrix)}\n");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }


    private static int MinElementInLargestColumn(int[][] matrix)
    {
        List<int> q = []; //index of largest column
        
        Int64 maxSumColumn = 0;

        for (int j = 0; j < matrix[0].Length; j++)
        {
            Int64 sum = 0;
            
            for (int i = 0; i < matrix.Length; i++)
            {
                sum += matrix[i][j];
            }
            
            if (sum > maxSumColumn)
            {
                maxSumColumn = sum;
                q = [j];
            }
            else if (sum == maxSumColumn)
            {
                q.Add(j);
            }
        }
        
        int[] minElements = new int[q.Count];
        
        for (int i = 0; i < q.Count; i++)
        {
            minElements[i] = matrix[0][q[i]];
            
            for (int j = 1; j < matrix.Length; j++)
            {
                if (matrix[j][q[i]] < minElements[i])
                {
                    minElements[i] = matrix[j][q[i]];
                }
            }
        }
        
        return minElements.Min();
    }
}