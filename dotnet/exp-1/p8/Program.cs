/*
Write a C# program to get – set Name and Age property using Read-Write property.
*/
using System;

namespace Zzz
{
    class Student
    {
        string name;
        int age;
        public string nm
        {
            get { return name; }
            set { name = value; }
        }
        public int ag
        {
            get { return age; }
            set { age = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.Write("Enter your name : ");
            s.nm = Console.ReadLine();
            Console.Write("Enter your age  : ");
            s.ag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is " + s.nm);
            Console.WriteLine("Your age is " + s.ag);
            Console.ReadKey();
        }
    }
}