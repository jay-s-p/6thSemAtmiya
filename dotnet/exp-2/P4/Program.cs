/*
Write a C# program for delegate.
*/
using System;

namespace Zzz
{
    public delegate void del(char c, int a);

    class test
    {
        public static void encrypt(char c, int a)
        {
            int m = (int)c;
            m += a;
            Console.WriteLine("Encryption of " + c + " is " + (char)m);
        }
        public static void decrypt(char c, int a)
        {
            int m = (int)c;
            m -= a;
            Console.WriteLine("Decryption of " + c + " is " + (char)m);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            del enc = new del(test.encrypt);
            del dec = new del(test.decrypt);

            enc('c', 3);
            dec('f', 3);
            Console.ReadKey();
        }
    }
}