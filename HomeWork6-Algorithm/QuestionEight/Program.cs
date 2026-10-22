using System;
class Program
{
    static bool CanFormTriangle(int[] arr)
    {
        int n = arr.Length;

        if (n < 3)
            return false;

        Array.Sort(arr);

        for (int i = 0; i < n - 2; i++)
        {
            long a = arr[i];
            long b = arr[i + 1];
            long c = arr[i + 2];

            if (a + b > c)
                return true;
        }

        return false;
    }

    static void Main()
    {
        Console.Write("Please Enter Number : ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Please Enter Number Again : ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Result : {CanFormTriangle(arr).ToString().ToLowerInvariant()}"); 
    }
}
