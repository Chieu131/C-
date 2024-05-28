using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter another number: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = Sum(num1, num2);
        Console.WriteLine($"The sum of two numbers is: {sum}");
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }
}
