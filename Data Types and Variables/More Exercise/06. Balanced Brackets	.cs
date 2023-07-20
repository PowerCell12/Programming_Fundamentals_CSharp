using System;
using System.Collections.Generic;

public class BracketChecker
{
    public static bool AreBracketsBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count == 0 || stack.Pop() != '(')
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;  // If the stack is empty, all brackets are balanced.
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();

            if (AreBracketsBalanced(line))
            {
                Console.WriteLine("BALANCED");
                break;
            }
            else
            {
                Console.WriteLine("UNBALANCED");
                break;
            }
        }
    }
}
