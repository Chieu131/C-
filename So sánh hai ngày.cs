using System;

class Program
{
    static void Main()
    {
        DateTime date1 = new DateTime(2016, 8, 1, 0, 0, 0);
        DateTime date2 = new DateTime(2016, 8, 1, 12, 0, 0);

        if (date1 < date2)
        {
            Console.WriteLine($"{date1} is earlier than {date2}");
        }
        else if (date1 > date2)
        {
            Console.WriteLine($"{date1} is later than {date2}");
        }
        else
        {
            Console.WriteLine($"{date1} is the same time as {date2}");
        }
    }
}
