// ReSharper disable PossibleLossOfFraction
namespace LabWork7;

public class ShellSort: ISort
{
    public void Sort(ref double[] array)
    {   
        for(int i = array.Length/2; i > 0; i /= 2)
        {
            for(int j = i; j < array.Length; j++)
            {
                for(int k = j - i; k >= 0 && array[k] > array[k + i]; k -= i)
                {
                    (array[k], array[k + i]) = (array[k + i], array[k]);
                }
            }
        }
    }
    
}