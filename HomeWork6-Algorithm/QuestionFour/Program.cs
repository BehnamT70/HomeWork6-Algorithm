namespace QuestionFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Number : ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Please Enter Number Again: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Please Enter Number Target : ");
            int target = int.Parse(Console.ReadLine());

            HashSet<long> seen = new HashSet<long>();
            bool found = false;

            for (int i = 0; i < n; i++)
            {
                long complement = (long)target - arr[i];

                if (seen.Contains(complement))
                {
                    found = true;
                    break;
                }

                seen.Add(arr[i]);
            }

            Console.WriteLine(found ? "Yes" : "No");
            Console.ReadKey();
        }
    }
}
