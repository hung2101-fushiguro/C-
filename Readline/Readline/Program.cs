using System;   
internal class MyClass
{
    public static void Main(string[] args)
    {
        string name;
        int age;
        Console.WriteLine("Enter your name:");
        name = Console.ReadLine()!;
        Console.WriteLine("Enter your age:");
        string userInput = Console.ReadLine()!;
        age = Convert.ToInt32(userInput);
        Console.WriteLine("{0} {1} year olds", name, age);
        Console.ReadLine();
    }
}
