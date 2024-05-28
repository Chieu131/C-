using System;

class Program
{
    static void Main()
    {
        Console.Write("Please input a name: ");
        string name = Console.ReadLine();
        GreetUser(name);
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Welcome friend {name}!");
        Console.WriteLine("Have a nice day!");
    }
}
