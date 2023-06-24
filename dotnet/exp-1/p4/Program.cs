/*
Write C# program to perform multilevel inheritance.
*/
using System;

namespace Zzz
{
    class A
    {
        public void functionA()
        {
            Console.WriteLine("class A");
        }
    }

    class B : A
    {
        public void functionB()
        {
            Console.WriteLine("class B");
        }
    }

    class C : B
    {
        public void functionC()
        {
            Console.WriteLine("class C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("From derived class :-");
            C c = new C();
            c.functionA();
            c.functionB();
            c.functionC();

            Console.WriteLine("\nfor calling methods itself :-");
            A a = new A();
            B b = new B();
            a.functionA();
            b.functionB();
            c.functionC();

            Console.ReadKey();
        }
    }
}
