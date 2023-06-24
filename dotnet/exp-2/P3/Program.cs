/*
Write a C# code to Convert following
currency conversion.
Rupees to dollar, frank, euro.
*/
using System;

namespace Zzz
{
    class RupeeConverter
    {
        public double toDollar(double x)
        {
            return x * 0.012;
        }
        public double toFranc(double x)
        {
            return x * 0.011;
        }
        public double toEuro(double x)
        {
            return x * 0.011;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RupeeConverter rc = new RupeeConverter();

            Console.Write("Enter rupees : ");
            double rupees = double.Parse(Console.ReadLine());

            Console.WriteLine("Dollar is : " + rc.toDollar(rupees));
            Console.WriteLine("Franc is  : " + rc.toFranc(rupees));
            Console.WriteLine("Euro is   : " + rc.toEuro(rupees));
            Console.ReadKey();
        }
    }
}
