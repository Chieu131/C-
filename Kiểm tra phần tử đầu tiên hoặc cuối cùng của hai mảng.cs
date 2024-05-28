using System;

class Program
{
    static void Main()
    {
        int[] array1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
        int[] array2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };

        bool result = FirstOrLastElementEqual(array1, array2);
        Console.WriteLine($"Check if the first element or the last element of the two arrays are equal: {result}");
    }

    static bool FirstOrLastElementEqual(int[] array1, int[] array2)
    {
        return (array1[0] == array2[0] || array1[array1.Length - 1] == array2[array2.Length - 1]);
    }
}
