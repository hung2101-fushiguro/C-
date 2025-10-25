using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1
{
    internal class baitap3
    {
        const double PI = 3.14;
        public static void Main(string[] argss)
        {
            double radius;
            Console.WriteLine("Enter the radius:");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of the circle: {0}", PI * radius * radius);
            Console.ReadLine();
        }
    }
}
