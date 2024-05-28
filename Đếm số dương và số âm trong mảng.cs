using System;

class Program
{
    static void Main()
    {
        int[] array1 = { 10, -11, 12, -13, 14, -18, 19, -20 };
        CountPositiveNegative(array1);

        int[] array2 = { -4, -3, -2, 0, 3, 5, 6, 2, 6 };
        CountPositiveNegative(array2);

        int[] array3 = { };
        CountPositiveNegative(array3);
    }

    static void CountPositiveNegative(int[] array)
    {
        int positiveCount = 0;
        int negativeCount = 0;

        foreach (int num in array)
        {
            if (num > 0)
            {
                positiveCount++;
            }
            else if (num < 0)
            {
                negativeCount++;
            }
        }

        Console.WriteLine("Number of positive numbers: " + positiveCount);
        Console.WriteLine("Number of negative numbers: " + negativeCount);
    }
}
