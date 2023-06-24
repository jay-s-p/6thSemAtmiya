/*
Write C# code to prompt a user to input his/her name and country name and then the output will be shown as an example below: Hello Ram from country India!
*/
using System;

namespace Zzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name : ");
            string name = Console.ReadLine();

            Console.Write("Enter country : ");
            string country = Console.ReadLine();
            
            Console.Write("\nHello " + name + " from country " + country + "!");
            Console.ReadKey();
        }
    }
}
