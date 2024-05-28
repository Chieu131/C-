using System;

class Program
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        DateTime yesterday = today.AddDays(-1);
        Console.WriteLine($"Today is: {today:dd/MM/yyyy}");
        Console.WriteLine($"The Yesterday was: {yesterday:dd/MM/yyyy}");
    }
}
