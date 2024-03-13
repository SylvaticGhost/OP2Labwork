namespace Labwork5;

public static class Task2 //5
{
    public static void Main()
    {
        for (int i = 4; i < 16; i += 3)
        {
            try
            {
                int[][] matrix = Helpers.GenerateMatrix(i, i);
                Console.WriteLine($"Matrix {i}x{i}:");
                Helpers.PrintMatrix(matrix);
                Console.WriteLine();
            
                ClearNE(matrix);
            
                Console.WriteLine("Matrix after clearing upper main diagonal:");
                Helpers.PrintMatrix(matrix);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
    
    //Task to delete all element upper main diagonal
    static void ClearNE(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for(int j = i; j < matrix[i].Length; j++)
            {
                matrix[i][j] = 0;
            }
        }
    }
}