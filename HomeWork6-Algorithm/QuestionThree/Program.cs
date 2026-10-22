namespace QuestionThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Number : ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine(0);
                return;
            }

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Please Enter Number Again : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int currentLength = 1;
            int maxLength = 1;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }

            Console.WriteLine($"Result : {maxLength}");
            Console.ReadKey();
        }
    }
}
