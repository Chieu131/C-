using System;

class Program
{
    static void Main()
    {
        Console.Write("Input the number of terms: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0.0;
        Console.Write("1");
        for (int i = 2; i <= n; i++)
        {
            Console.Write(" + 1/" + i);
            sum += 1.0 / i;
        }
        sum += 1.0;
        Console.WriteLine();
        Console.WriteLine($"Sum of Series upto {n} terms : {sum}");
    }
}
