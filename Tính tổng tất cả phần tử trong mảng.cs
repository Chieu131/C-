using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
        int sum = SumArray(array);
        Console.WriteLine($"Sum: {sum}");
    }

    static int SumArray(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }
}
