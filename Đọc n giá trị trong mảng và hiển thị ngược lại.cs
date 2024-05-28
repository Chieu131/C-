using System;

class Program
{
    static void Main()
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The values store into the array are:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nThe values store into the array in reverse are:");
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
