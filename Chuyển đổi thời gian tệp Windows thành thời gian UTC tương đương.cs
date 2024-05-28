using System;

class Program
{
    static void Main()
    {
        long fileTime = DateTime.Now.ToFileTime();
        DateTime utcTime = DateTime.FromFileTimeUtc(fileTime);
        Console.WriteLine(utcTime);
    }
}
