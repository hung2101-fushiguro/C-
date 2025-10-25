using calculator.Method;
using System;
namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Enter a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Convert.ToDouble(Console.ReadLine());
            Calculation cal = new Calculation();
            Console.WriteLine("Sum: {0}", cal.sum(a, b));
            Console.ReadLine();
         
        }
    }
}