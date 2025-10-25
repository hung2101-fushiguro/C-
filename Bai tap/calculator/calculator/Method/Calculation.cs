using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Method
{
    public class Calculation
    {
        public double sum(double a, double b)
        {
            return a + b;
        }
        public double subtract(double a, double b)
        {
            return a - b;
        }
        public double multiply(double a, double b)
        {
            return a * b;
        }
        public double divide(double a, double b)
        {
            if (b == 0)
            {
              Console.WriteLine("error!");
            }
            return a / b;
        }
    }
}
