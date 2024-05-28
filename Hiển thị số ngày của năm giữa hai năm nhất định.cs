using System;

class Program
{
    static void Main()
    {
        int startYear = 2001;
        int endYear = 2008;

        for (int year = startYear; year <= endYear; year++)
        {
            DateTime lastDayOfYear = new DateTime(year, 12, 31);
            Console.WriteLine($"{lastDayOfYear:MM/dd/yyyy}: day {lastDayOfYear.DayOfYear} of {year}");
        }
    }
}
