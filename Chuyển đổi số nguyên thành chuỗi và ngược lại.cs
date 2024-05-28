using System;

class Program
{
    static void Main()
    {
        // Convert string to integer
        string str = "50";
        int intValue = int.Parse(str);
        Console.WriteLine($"Original value and type: {str}, {str.GetType()}");
        Console.WriteLine($"Convert string to integer: ");
        Console.WriteLine($"Return value and type: {intValue}, {intValue.GetType()}");

        // Convert integer to string
        int number = 122;
        string strValue = number.ToString();
        Console.WriteLine($"Original value and type: {number}, {number.GetType()}");
        Console.WriteLine($"Convert integer to string: ");
        Console.WriteLine($"Return value and type: {strValue}, {strValue.GetType()}");
    }
}
