namespace LabWork7;

public class SortingContext(ISort sort)
{
    public void Sort(ref double[] array)
    {
        sort.Sort(ref array);
    }
}