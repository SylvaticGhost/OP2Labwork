namespace LabWork7;

public class SelectionSort : ISort
{
    public void Sort(ref double[] array)
    {
        Helpers.ValidateArray(ref array);
        
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
}