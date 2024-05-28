using System;

class Program
{
    static void Main()
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine($"Complete date: {dt}");
        Console.WriteLine($"Short Date: {dt.ToShortDateString()}");
        Console.WriteLine($"Display date using 24-hour clock format:");
        Console.WriteLine(dt.ToString("dd/MM/yyyy HH:mm"));
    }
}
