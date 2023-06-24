/*
Write a C# program for Employee Information using Constructor(Name and Age).
*/
using System;

namespace Zzz
{
    class Employee
    {
        string name;
        int age;

        public Employee()
        {
            Console.WriteLine("Employee Object Created");
        }

        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine(this.name + " : " + this.age);
        }

        public Employee(Employee c)
        {
            this.name = c.name;
            this.age = c.age;
            Console.WriteLine(this.name + " : " + this.age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee 1 :-");
            Employee e1 = new Employee();
            Console.WriteLine("\nEmployee 2 :-");
            Employee e2 = new Employee("Jay", 20);
            Console.WriteLine("\nEmployee 3 :-");
            Employee e3 = new Employee(e2);
            Console.ReadKey();
        }
    }
}
