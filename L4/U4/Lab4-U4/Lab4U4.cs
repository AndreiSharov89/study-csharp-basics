// Sharov Andrei group 124/11
using Lab4_U4;

namespace Lab4_U4
{
    using System;


    public class Lab4U4
    {
        public static void Main()
        {
        Console.WriteLine("Sides are equal? y/n");
        string type = Console.ReadLine();
        if (type == "y") 
        {
            Console.WriteLine("Enter first side");
            double a = double.Parse(Console.ReadLine());
            double space = Operation.TriSpace(a);
            Console.WriteLine($"Space of trianlge is {space:F2}");
        }

        else
        {
            Console.WriteLine("Enter first side");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second side");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third side");
            double c = double.Parse(Console.ReadLine());
            double space = Operation.TriSpace(a, b ,c);
            Console.WriteLine($"Space of trianlge is {space:F2}");
        }

        }
    }
}
