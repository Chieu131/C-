using System;

class Program
{
    static void Main()
    {
        DateTime current = DateTime.Now;
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine(current.AddMonths(i).ToString("MMM"));
        }
    }
}
