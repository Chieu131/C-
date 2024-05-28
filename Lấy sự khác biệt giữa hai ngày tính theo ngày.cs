using System;

class Program
{
    static void Main()
    {
        DateTime date1 = new DateTime(2016, 1, 1);
        DateTime date2 = new DateTime(2022, 3, 10);
        TimeSpan difference = date2 - date1;
        Console.WriteLine($"Difference in days: {difference.Days}");
    }
}
