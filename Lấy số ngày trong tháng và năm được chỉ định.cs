using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(DateTime.DaysInMonth(2023, 1)); // 31
        Console.WriteLine(DateTime.DaysInMonth(2023, 2)); // 28
        Console.WriteLine(DateTime.DaysInMonth(2024, 2)); // 29 (năm nhuận)
    }
}
