/*
Write a C# program to count number of objects using static property.
*/
using System;

namespace Zzz
{
    class test
    {
        static int count = 0;

        public test()
        {
            ++count;
        }
        public static int c
        {
            get
            {
                return count;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            test t1 = new test();
            test t2 = new test();
            test t3 = new test();
            Console.WriteLine("Total objects : " + test.c);
            Console.ReadKey();
        }
    }
}