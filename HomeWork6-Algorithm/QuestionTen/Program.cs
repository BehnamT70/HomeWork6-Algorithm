
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Write("Enter the Number of Values : ");
        int n = int.Parse(Console.ReadLine()!);

        if (n < 3)
        {
            Console.WriteLine("At Least 3 Items are Required.");
            return;
        }

        long max1 = long.MinValue;
        long max2 = long.MinValue;
        long max3 = long.MinValue;

        long min1 = long.MaxValue;
        long min2 = long.MaxValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Please Enter Number  {i + 1} : ");
            long x = long.Parse(Console.ReadLine()!);

            if (x >= max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = x;
            }
            else if (x >= max2)
            {
                max3 = max2;
                max2 = x;
            }
            else if (x > max3)
            {
                max3 = x;
            }

            if (x <= min1)
            {
                min2 = min1;
                min1 = x;
            }
            else if (x < min2)
            {
                min2 = x;
            }
        }

        BigInteger product1 =
            (BigInteger)max1 * max2 * max3;

        BigInteger product2 =
            (BigInteger)min1 * min2 * max1;

        BigInteger answer = BigInteger.Max(product1, product2);

        Console.WriteLine("Largest Product : " + answer);
        Console.ReadKey();
    }
}
