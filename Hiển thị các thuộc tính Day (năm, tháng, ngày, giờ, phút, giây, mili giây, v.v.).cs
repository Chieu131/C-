using System;

class Program
{
    static void Main()
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine($"year = {dt.Year}");
        Console.WriteLine($"month = {dt.Month}");
        Console.WriteLine($"day = {dt.Day}");
        Console.WriteLine($"hour = {dt.Hour}");
        Console.WriteLine($"minute = {dt.Minute}");
        Console.WriteLine($"second = {dt.Second}");
        Console.WriteLine($"millisecond = {dt.Millisecond}");
    }
}
