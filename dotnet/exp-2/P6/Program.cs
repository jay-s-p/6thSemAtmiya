/*
Write C# code to display the asterisk pattern
as shown below:
 1) ***** 2) *****
    *****    ****
    *****    ***
    *****    **
    *****    *
*/

using System;

namespace Zzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
