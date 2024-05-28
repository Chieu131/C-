using System;

class Program
{
    static void Main()
    {
        int number1 = 12;
        CountBinaryOnesZeros(number1);

        int number2 = 1234;
        CountBinaryOnesZeros(number2);
    }

    static void CountBinaryOnesZeros(int number)
    {
        string binary = Convert.ToString(number, 2);
        int ones = 0;
        int zeros = 0;

        foreach (char bit in binary)
        {
            if (bit == '1')
            {
                ones++;
            }
            else
            {
                zeros++;
            }
        }

        Console.WriteLine($"Original number: {number}");
        Console.WriteLine($"Number of ones and zeros in the binary representation of the said number:");
        Console.WriteLine($"Number of ones: {ones}");
        Console.WriteLine($"Number of zeros: {zeros}");
    }
}
