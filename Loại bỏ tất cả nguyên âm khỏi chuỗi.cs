using System;

class Program
{
    static void Main()
    {
        Console.Write("Input a string: ");
        string input = Console.ReadLine();
        string result = RemoveVowels(input);
        Console.WriteLine($"After removing all the vowels from the said string: {result}");
    }

    static string RemoveVowels(string str)
    {
        string vowels = "aeiouAEIOU";
        foreach (char vowel in vowels)
        {
            str = str.Replace(vowel.ToString(), "");
        }
        return str;
    }
}
