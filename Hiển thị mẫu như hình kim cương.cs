using System;

class Program
{
    static void Main()
    {
        int n = 5; // Độ cao của kim cương
        for (int i = 1; i <= n; i += 2)
        {
            Console.Write(new string(' ', (n - i) / 2));
            Console.WriteLine(new string('*', i));
        }
        for (int i = n - 2; i >= 1; i -= 2)
        {
            Console.Write(new string(' ', (n - i) / 2));
            Console.WriteLine(new string('*', i));
        }
    }
}
