using System;

class Program
{
    static void Main()
    {
        Console.Write("Input the Day : ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Input the Month : ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Input the Year : ");
        int year = int.Parse(Console.ReadLine());

        DateTime inputDate = new DateTime(year, month, day);
        DateTime nextMonth = inputDate.AddMonths(1);
        DateTime firstDayOfNextMonth = new DateTime(nextMonth.Year, nextMonth.Month, 1);

        Console.WriteLine($"The formatted Date is : {inputDate:dd/MM/yyyy}");
        Console.WriteLine($"The first day of the next month for the above date is: {firstDayOfNextMonth:dd/MM/yyyy}");
    }
}
