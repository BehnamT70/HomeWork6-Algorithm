namespace QuestionTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Number : ");
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Result : Not Prime");
                return;
            }

            if (n == 2)
            {
                Console.WriteLine("Result : Prime");
                return;
            }

            if (n % 2 == 0)
            {
                Console.WriteLine("Result : Not Prime");
                return;
            }

            for (int i = 3; i <= n / i; i += 2)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Result : Not Prime");
                    return;
                }
            }

            Console.WriteLine("Result : Prime");
            Console.ReadKey();
        }

    }
}
