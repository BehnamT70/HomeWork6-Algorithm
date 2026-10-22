using System.Numerics;

namespace QuestionOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Number : ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            BigInteger a = 0;
            BigInteger b = 1;

            if (n == 0)
            {
                Console.WriteLine(a);
                return;
            }

            for (int i = 2; i <= n; i++)
            {
                BigInteger next = a + b;
                a = b;
                b = next;
            }

            Console.WriteLine($"Result :{b}");
            Console.ReadKey();
        }

    }
}
