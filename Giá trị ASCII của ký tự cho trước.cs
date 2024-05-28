using System;

class Program
{
    static void Main()
    {
        Console.Write("Input a character: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.WriteLine($"ASCII value of {ch} is: {(int)ch}");
    }
}
