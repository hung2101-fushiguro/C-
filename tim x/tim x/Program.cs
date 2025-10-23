using System;
internal class FindX
{
    public static void Main(string[] args)
    {
        double a, b, c;
        Console.WriteLine("Enter a, b, c: ax+b=c");
        Console.WriteLine("a");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("b");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("c");
        c = Convert.ToDouble(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("Error");
        }
        else
        {
            double x = (c - b) / a;
            Console.WriteLine("x = " + x);
            Console.Read();
        }
    }
}