void FillArray(int[] array, int minimum, int maximum)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(minimum, maximum);
}
void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write($"{element} ");
    Console.WriteLine();
}
Console.Write("Enter size of array: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[size];
FillArray(array, 10, 50);
Console.Write("Your array: ");
PrintArray(array);
int oddsCount = array.Count(value => value%2==0);
Console.WriteLine($"Amount of odds: {oddsCount}");
int[] oddsArray = (from element in array where element%2==0 select element).ToArray();
Console.Write("Odds numbers: ");
PrintArray(oddsArray);

