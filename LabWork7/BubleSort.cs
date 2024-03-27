namespace LabWork7;

public class BubleSort : ISort
{
    public void Sort(ref double[] array)
    {
        Helpers.ValidateArray(ref array);
        
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
}