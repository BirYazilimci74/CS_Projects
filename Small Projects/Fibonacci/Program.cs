using System;

namespace Fibonacci
{
    class Program
    {
        private static void FibonacciTree(int n)
        {
            int x, y;
            x = 2 * n - 1;
            y = n;
            bool b = false;
            string[,] tree = new string[x,y];

            int count = 0;
            int count2 = 0;
            string text;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    int center = x/2;
                    if (j == center && i == 0)
                    {
                        text = "f(" + n + ") ";
                        tree[j,i] = text;
                    }
                    else if (j == (center-count) && i == (0 + count))
                    {
                        text = "f(" + (n - count) + ") ";
                        tree[j,i] = text;
                        j++;
                        count++;
                        text = "f(" + (n - count) + ")   ";
                        tree[j,i] = text;
                        count--;
                    }
                    else if (j == (center+count2) && i == (0 + count) && (n - 2*count >= 0))
                    {
                        if (b)
                        {
                            text = "f(" + (n - 2*count) + ") ";
                            tree[j,i] = text;
                        }
                        b = true;
                        j--;
                        text = "f(" + ((n+1) - 2*count) + ") ";
                        tree[j,i] = text;
                        j++;
                    }
                    else
                    {
                        tree[j,i] = "   ";
                    }
                }
                count++;
                count2++;
            }
            
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(tree[j,i]);
                }
                Console.WriteLine();
            }
        }
        
        public static void Main()
        {
            FibonacciTree(7);   
        }
    }
}

