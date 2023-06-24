/*
Write a C# program to print Name of 6th sem subject using indexer.
*/
using System;

namespace Zzz
{
    class test
    {
        string[] s = new string[6];
        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < s.Length)
                    return s[i];
                return "";
            }
            set
            {
                if (i >= 0 && i < s.Length)
                    s[i] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            test t = new test();
            t[0] = "a";
            t[1] = "b";
            t[2] = "c";
            t[3] = "d";
            t[4] = "e";
            t[5] = "f";
            for (int i = 0; i < 6; i++)
                Console.Write(t[i] + " ");

            Console.ReadKey();
        }
    }
}