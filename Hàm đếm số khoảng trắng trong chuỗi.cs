using System;

class Program
{
    static void Main()
    {
        Console.Write("Please input a string: ");
        string input = Console.ReadLine();

        int spaceCount = CountSpaces(input);
        Console.WriteLine($"\"{input}\" contains {spaceCount} spaces");
    }

    static int CountSpaces(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == ' ')
            {
                count++;
            }
        }
        return count;
    }
}
