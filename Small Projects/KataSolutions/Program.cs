using System;
using System.Linq;
using System.Collections.Generic;

public class Brace {

    public static bool validBraces(String braces)
    {
        Stack<char> stack = new Stack<char>();
        
        foreach (char ch in braces)
        {
            if(ch == '(' || ch == '[' || ch == '{')
            {
                stack.Push(ch);
            }
            else
            {
                if(stack.Count == 0) return false;

                char last = stack.Pop();
                if((last != '(' && ch == ')') || (last != '[' && ch == ']') || (last != '{' && ch == '}'))
                {
                    return false;
                }
            }
        }
        
        return stack.Count == 0;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(validBraces("{[()]]}"));
    }
}


/*
"(){}[]"   =>  True
"([{}])"   =>  True
"(}"       =>  False
"[(])"     =>  False
"[({})](]" =>  False
*/