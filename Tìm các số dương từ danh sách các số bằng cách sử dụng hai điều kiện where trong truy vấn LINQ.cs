using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { -1, 1, 2, 3, -5, 6, -7, 8, 9, -10, 11 };

        var query = from num in numbers
                    where num > 0
                    where num <= 11
                    select num;

        Console.WriteLine("The numbers within the range of 1 to 11 are:");
        foreach (var num in query)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
