namespace Labwork4;

public static class Helpers
{
    public static T[] GenerateArray<T>(int size) where T : struct, IComparable, IFormattable, IConvertible
    {
        Random random = new Random();
        T[] array = new T[size];

        if (typeof(T) == typeof(int))
        {
            for (int i = 0; i < size; i++)
                array[i] = (T)(object)random.Next(-100, 100);

            return array;
        }

        if (typeof(T) == typeof(double))
        {
            for (int i = 0; i < size; i++)
                array[i] = (T)(object)(random.NextDouble() * 200 - 100);

            return array;
        }

        throw new ArgumentException("Type not supported");
    }


    public static void PrintArray<T>(IEnumerable<T> array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}