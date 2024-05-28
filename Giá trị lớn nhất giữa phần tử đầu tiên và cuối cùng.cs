using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 5, 7, 8 };
        int max = MaxFirstLast(array);
        Console.WriteLine($"Highest value between first and last values of the said array: {max}");
    }

    static int MaxFirstLast(int[] array)
    {
        return Math.Max(array[0], array[array.Length - 1]);
    }
}
