/*
Write a program for Fibonacci & Factorial.
*/
using System;

namespace Zzz
{
    class Program
    {
        static void Fibonacci(int n)
        {
            if (n == 1)
                Console.Write("0");
            else if (n == 2)
                Console.Write("0, 1");
            else
            {
                Console.Write("0, 1");
                int f1 = 0, f2 = 1, f3;
                for (int i = 3; i <= n; i++)
                {
                    f3 = f1 + f2;
                    f1 = f2;
                    f2 = f3;
                    Console.Write(", " + f3);
                }
            }
        }

        static void Factorial(int n)
        {
            int ans = 1;
            for (int i = n; i > 0; i--)
                ans *= i;
            Console.Write("Factorial of " + n + " is " + ans);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter value for fibonacci series : ");
            int n = int.Parse(Console.ReadLine());
            Fibonacci(n);

            Console.Write("\n\nEnter value for fibonacci series : ");
            n = int.Parse(Console.ReadLine());
            Factorial(n);
            
            Console.ReadKey();
        }
    }
}
