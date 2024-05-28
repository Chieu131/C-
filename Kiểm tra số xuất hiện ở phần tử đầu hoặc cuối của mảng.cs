using System;

class Program
{
    static void Main()
    {
        Console.Write("Input an integer: ");
        int num = int.Parse(Console.ReadLine());

        int[] array = { 1, 2, 3, 4, 25, 5, 6, 7 };

        bool result = IsFirstOrLastElement(array, num);
        Console.WriteLine(result);
    }

    static bool IsFirstOrLastElement(int[] array, int num)
    {
        return (array[0] == num || array[array.Length - 1] == num);
    }
}
