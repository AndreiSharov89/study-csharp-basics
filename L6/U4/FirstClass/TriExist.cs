// Sharov Andrei group 124/11
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class TriExist
    {
        static void Main()
        {
            //interface
            Triangle new1 = NewTriangle();
            OutputTriangle(new1);
        }
        
        
        //create
        static Triangle NewTriangle()
        {
            Triangle triangle = new Triangle();

            Console.WriteLine("Enter side A:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side C:");
            double c = double.Parse(Console.ReadLine());
            triangle.Create(a, b, c);
            return triangle;
        }


        //output compilation
        static void OutputTriangle(Triangle tri)
        {
            Console.WriteLine($"Sides: {tri.SideA():F2}, {tri.SideB():F2}, {tri.SideC():F2}.");
            if (tri.IsExist())
            {
                Console.WriteLine("Triangle exist!");
                Console.WriteLine($"Perimetr = {tri.Perimetr():F2}, Space = {tri.Space():F2}.");
            }
            else
            {
                Console.WriteLine($"Triangle doesn't exist, sorry.");
            }
        }
    }
}
