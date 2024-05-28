using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 8 };
        RotateLeft(array);

        Console.WriteLine("After rotating array becomes: ");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }

    static void RotateLeft(int[] array)
    {
        int first = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = first;
    }
}
