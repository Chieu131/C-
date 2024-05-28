using System;

class Program
{
    static void Main()
    {
        DateTime localDateTime = DateTime.Now;
        DateTime utcDateTime = localDateTime.ToUniversalTime();

        Console.WriteLine($"Local time: {localDateTime}");
        Console.WriteLine($"UTC time: {utcDateTime}");
    }
}
