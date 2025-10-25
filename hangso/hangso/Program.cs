using System;
namespace hangso
{
    class Program
    {
        const double Pi = 3.14;
        const int NumberOfweeksInYear = 52;
        const string BirthdayOfAdmin = "21/01/2005";
        static void Main(string[] args)
        {
            double radius = 10.0;
            Console.WriteLine("Admin's Birthday: {0} ",  BirthdayOfAdmin);
            Console.WriteLine("Area of circle: {0}",radius * radius * Pi);
            Console.ReadKey();
      
        }
    }
}