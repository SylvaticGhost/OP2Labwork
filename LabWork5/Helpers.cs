namespace Labwork5;

public static class Helpers
{
    public static int[][] GenerateMatrix(int m, int n)
    {
        int[][] matrix = new int[m][];
        
        for (int i = 0; i < m; i++)
        {
            matrix[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                matrix[i][j] = new Random().Next(-100, 100);
            }
        }
        
        return matrix;
    }
    
    
    public static void PrintMatrix(int[][] matrix)
    {
        foreach (var row in matrix)
        {
            foreach (var e in row)
            {
                Console.Write(e + "\t ");
            }

            Console.WriteLine();
        }
    }
    
}