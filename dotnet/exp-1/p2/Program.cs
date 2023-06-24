/*
Write a C# program which prints car details(Car name and mileage) using Copy Constructor.
*/
using System;

namespace Zzz
{
    class Car
    {
        string name;
        int mil;

        public Car()
        {
            Console.WriteLine("Car Object Created");
        }
        public Car(string name, int mil)
        {
            this.name = name;
            this.mil = mil;
            Console.WriteLine(this.name + " : " + this.mil);
        }
        public Car(Car c)
        {
            this.name = c.name;
            this.mil = c.mil;
            Console.WriteLine(this.name + " : " + this.mil);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car 1 :-");
            Car c1 = new Car();
            Console.WriteLine("\nCar 2 :-");
            Car c2 = new Car("MBW", 987654321);
            Console.WriteLine("\nCar 3 :-");
            Car c3 = new Car(c2);
            Console.ReadKey();
        }
    }
}
