using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.twoDimension
{
    public class Circle : twoDimensionShape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double getArea()
        {
            return Math.PI * radius * radius;
        }
        public override void showResult()
        {
            Console.WriteLine("Circle Area: " + getArea());
        }
    }
}
