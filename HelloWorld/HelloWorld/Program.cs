using System;
using System.Runtime.InteropServices.Marshalling;
namespace HelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int firstNumber = 5, secondNuber = 10;
            int result = firstNumber + secondNuber;
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNuber, result);
            Console.Read();
           
        }
    }

}
