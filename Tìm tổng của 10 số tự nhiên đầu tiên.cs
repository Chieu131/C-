using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        Console.WriteLine("The first 10 natural number is:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
            sum += i;
        }
        Console.WriteLine();
        Console.WriteLine($"The Sum is: {sum}");
    }
}
