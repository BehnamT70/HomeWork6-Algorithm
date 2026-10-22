
using System;
class Program
{
    static string[] ones =
    {
        "", "One", "Two", "Three", "Four",
        "Five", "Six", "Seven", "Eight", "Nine"
    };

    static string[] teens =
    {
        "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
        "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
    };

    static string[] tens =
    {
        "", "", "Twenty", "Thirty", "Forty",
        "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
    };

    static string ConvertNumber(int n)
    {
        string result = "";

        if (n >= 1000)
        {
            result += ones[n / 1000] + " Thousand";
            n %= 1000;

            if (n > 0)
                result += " ";
        }

        if (n >= 100)
        {
            result += ones[n / 100] + " Hundred";
            n %= 100;

            if (n > 0)
                result += " ";
        }

        if (n >= 20)
        {
            result += tens[n / 10];
            n %= 10;

            if (n > 0)
                result += " " + ones[n];
        }
        else if (n >= 10)
        {
            result += teens[n - 10];
        }
        else if (n > 0)
        {
            result += ones[n];
        }

        return result.Trim();
    }

    static void Main()
    {
        Console.Write("Enter a number (1-9999): ");

        if (!int.TryParse(Console.ReadLine(), out int n)
            || n < 1 || n > 9999)
        {
            Console.WriteLine("Resualt : Invalid Input");
            return;
        }

        Console.WriteLine($"Result : {ConvertNumber(n)}");
        Console.ReadKey();
    }
}
