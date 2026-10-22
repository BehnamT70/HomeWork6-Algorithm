
using System;

class Program
{
    static int ReverseNumber(int x)
    {
        long reversed = 0;

        while (x != 0)
        {
            int digit = x % 10;
            x /= 10;

            reversed = reversed * 10 + digit;

            if (reversed > int.MaxValue ||
                reversed < int.MinValue)
            {
                return 0;
            }
        }

        return (int)reversed;
    }

    static void Main()
    {
        Console.Write("Enter an Integer: ");

        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Result : Invalid Input");
            return;
        }

        Console.WriteLine($"Result : {ReverseNumber(n)}");
        Console.ReadKey();
    }
}
