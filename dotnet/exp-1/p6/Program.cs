/*
Write a C# program for polymorphism.
*/
using System;

namespace Zzz
{
    class A
    {
        public virtual void print()
        {
            Console.WriteLine("Base class");
        }
    }

    class B : A
    {
        public override void print()
        {
            Console.WriteLine("Derived class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            a.print();
            b.print();
            Console.ReadKey();
        }
    }
}
