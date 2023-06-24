/*
Write a C# program for illustrate Interface.
*/
using System;

namespace Zzz
{
    public interface stu
    {
        void display();
    }
    class derived : stu{
        public derived()
        {
            Console.WriteLine("Constructor called");
        }
        public void display()
        {
            Console.WriteLine("Display method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            derived ob = new derived();
            ob.display();
            Console.ReadKey();
        }
    }
}
