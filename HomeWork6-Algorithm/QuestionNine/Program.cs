using System;
using System.Collections.Generic;
class Program
{
    static bool IsBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0)
                    return false;

                char top = stack.Pop();

                if ((c == ')' && top != '(') ||
                    (c == ']' && top != '[') ||
                    (c == '}' && top != '{'))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return stack.Count == 0;
    }

    static void Main()
    {
        Console.Write("Please Enter String : ");
        string input = Console.ReadLine() ?? "";

        Console.WriteLine($"Result : {IsBalanced(input).ToString().ToLowerInvariant()}");
        Console.ReadKey();
    }
}
