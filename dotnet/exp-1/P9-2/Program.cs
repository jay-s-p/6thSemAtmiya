/*
Write a C# program to print Name of 6th sem subject using indexer.
*/
using System;
namespace Zzz
{
    class Student
    {
        string name;
        int age;
        public object this[int i]
        {
            get
            {
                if (i == 0)
                    return name;
                else if (i == 1)
                    return age;
                else
                    return null;
            }
            set
            {
                if (i == 0)
                    name = (string)value;
                else if (i == 1)
                    age = (int)value;
                else
                    Console.WriteLine("Invalid value!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.Write("Enter your name : ");
            s[0] = Console.ReadLine();
            Console.Write("Enter your age  : ");
            s[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is " + s[0]);
            Console.WriteLine("Your age is " + s[1]);
            Console.ReadKey();
        }
    }
}