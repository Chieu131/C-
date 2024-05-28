using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Input the number of elements to be stored in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            array[i] = int.Parse(Console.ReadLine());
        }

        HashSet<int> uniqueElements = new HashSet<int>();
        foreach (int num in array)
        {
            if (Array.FindAll(array, x => x == num).Length == 1)
            {
                uniqueElements.Add(num);
            }
        }

        Console.WriteLine("The unique elements found in the array are:");
        foreach (int num in uniqueElements)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
