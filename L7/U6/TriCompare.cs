// Sharov Andrei group 124/11
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class TriCompare
    {
        static void Main()
        {
            //user interface
            Triangle new1 = NewTriangle();
            Triangle new2 = NewTriangle();
            if (new1.IsExist() && new2.IsExist())
            {
                if (new1.Space() == new2.Space())
                {
                    Console.WriteLine("Triangles are equal in space");
                    OutputTriangle(new1);
                    OutputTriangle(new2);
                }
                else
                {
                    Triangle[] triangles = new Triangle[2];
                    triangles[0] = new1;
                    triangles[1] = new2;
                    Array.Sort(triangles);
                    Console.WriteLine("smaller trianlgle:");
                    OutputTriangle(triangles[0]);
                    Console.WriteLine();
                    Console.WriteLine("bigger trianlgle:");
                    OutputTriangle(triangles[1]);
                }
            }
            else
            {
                Console.WriteLine("Can't compare. Maybe one of triangles does not exist?");
            }
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
