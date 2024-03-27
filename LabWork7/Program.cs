using LabWork7;

double[] array;

Helpers.WriteTitle("Bubble sort");
array = Helpers.GenerateArray(10);
Console.Write("Initial array: ");
Helpers.WriteCollection(array);

SortingContext sortingContext = new(new BubleSort());
sortingContext.Sort(ref array);

Console.Write("Sorted array: ");
Helpers.WriteCollection(array);
Console.WriteLine();


Helpers.WriteTitle("Selection sort");
array = Helpers.GenerateArray(10);
Console.Write("Initial array: ");
Helpers.WriteCollection(array);

sortingContext = new(new SelectionSort());
sortingContext.Sort(ref array);

Console.Write("Sorted array: ");
Helpers.WriteCollection(array);
Console.WriteLine();


Helpers.WriteTitle("Shell sort");
array = Helpers.GenerateArray(10);
Console.Write("Initial array: ");
Helpers.WriteCollection(array);

sortingContext = new(new ShellSort());
sortingContext.Sort(ref array);

Console.Write("Sorted array: ");
Helpers.WriteCollection(array);

