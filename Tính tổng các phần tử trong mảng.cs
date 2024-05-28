using System;

class Program
{
    static void Main()
    {
        int[] array = new int[5];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"element - {i} : ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = SumArray(array);
        Console.WriteLine($"The sum of the elements of the array is {sum}");
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
