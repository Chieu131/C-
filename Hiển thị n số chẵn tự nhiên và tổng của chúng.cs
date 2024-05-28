using System;

class Program
{
    static void Main()
    {
        Console.Write("Input number of terms: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        Console.WriteLine("The even numbers are:");
        for (int i = 1; i <= n; i++)
        {
            int evenNumber = 2 * i;
            Console.Write(evenNumber + " ");
            sum += evenNumber;
        }
        Console.WriteLine();
        Console.WriteLine($"The Sum of even Natural Number upto {n} terms: {sum}");
    }
}
