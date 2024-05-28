using System;

class Program
{
    static void Main()
    {
        int[] array = new int[10];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"element - {i} : ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Elements in array are: ");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
