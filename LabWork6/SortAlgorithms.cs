namespace LabWork6;

public static class SortAlgorithms
{
    public static void BubbleSort(ref double[] array)
    {
        ValidateArray(ref array);
        
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }
    
    
    public static void SelectionSort(ref double[] array)
    {
        ValidateArray(ref array);
        
        for (int i = 0; i < array.Length; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }

            if (min != i)
            {
                (array[i], array[min]) = (array[min], array[i]);
            }
        }
    }


    private static void ValidateArray(ref double[] array)
    {
        if (array.Any(double.IsNaN))
            throw new ArgumentException("The array contains NaN, that can't be compared for sorting");
    }
}