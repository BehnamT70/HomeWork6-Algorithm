namespace QuestionSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter String : ");
            string input = Console.ReadLine();

            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (count.ContainsKey(c))
                {
                    count[c]++;
                }
                else
                {
                    count[c] = 1;
                }
            }

            foreach (char c in input)
            {
                if (count[c] == 1)
                {
                    Console.WriteLine($"Result : {c}");
                    return;
                }
            }

            Console.WriteLine("Result : -1");
            Console.ReadKey();
        }
    }
}
