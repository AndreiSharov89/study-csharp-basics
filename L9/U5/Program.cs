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
    public class Program
    {
        static void Main()
        {
            //user interface
            string typeCheck;
            Console.WriteLine("How many sides? (circle - 0)");
            int sides = int.Parse(Console.ReadLine());
            if (sides < 0)
            {
                Console.WriteLine("This option not yet realized.");
            }
            else
            {
                switch (sides)
                {
                    case 0:
                        Console.WriteLine("Enter radius:");
                        Circle cir = new Circle(double.Parse(Console.ReadLine()));
                        Console.WriteLine($"Your figure is {cir.Name()}");
                        Console.WriteLine($"Radius = {cir.Radius():F2}, perimetr = {cir.Perimetr():F2}, space = {cir.Space():F2}");
                        break;
                    case 1:
                        Console.WriteLine("This option not yet realized.");
                        break;
                    case 2:
                        Console.WriteLine("This option not yet realized.");
                        break;
                    case 3:
                        Console.WriteLine("Triangle has equal sides? y/n");
                        typeCheck = Console.ReadLine();
                        Triangle new1;
                        if (typeCheck == "y")
                        {
                            Console.WriteLine("Enter triangle side:");
                            new1 = new Triangle(double.Parse(Console.ReadLine()));
                        }
                        else
                        {
                            Console.WriteLine("Enter side A:");
                            double a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter side B:");
                            double b = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter side C:");
                            double c = double.Parse(Console.ReadLine());
                            new1 = new Triangle(a, b, c);
                        }
                        if (new1.IsExist())
                        {
                            Console.WriteLine($"Your figure is {new1.Name()}");
                            Console.WriteLine($"Sides = {new1.SideA():F2}, {new1.SideB():F2}, {new1.SideC():F2}");
                            Console.WriteLine($"Perimetr = {new1.Perimetr():F2}, Space = {new1.Space():F2}");
                            Console.WriteLine($"Rotated? {new1.IfRotated}");
                            Console.WriteLine($"Want to rotate? y/n");
                            if (Console.ReadLine() == "y")
                            {
                                new1.Rotate();
                                Console.WriteLine($"Rotated? {new1.IfRotated}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Triangle doesn't exist.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter side:");
                        Square sqr = new Square(double.Parse(Console.ReadLine()));
                        Console.WriteLine($"Your figure is {sqr.Name()}");
                        Console.WriteLine($"Sides = {sqr.Side():F2}, perimetr = {sqr.Perimetr():F2}, space = {sqr.Space():F2}");
                        Console.WriteLine($"Rotated? {sqr.IfRotated}");
                        Console.WriteLine($"Want to rotate? y/n");
                        if (Console.ReadLine() == "y")
                        {
                            sqr.Rotate();
                            Console.WriteLine($"Rotated? {sqr.IfRotated}");
                        }
                        break;
                    default:
                        Console.WriteLine("Enter side:");
                        Polygon pol = new Polygon(double.Parse(Console.ReadLine()), sides);
                        Console.WriteLine($"Your figure is {pol.Name()}");
                        Console.WriteLine($"Sides = {pol.Side():F2}, perimetr = {pol.Perimetr():F2}, space = {pol.Space():F2}");
                        Console.WriteLine($"Rotated? {pol.IfRotated}");
                        Console.WriteLine($"Want to rotate? y/n");
                        if (Console.ReadLine() == "y")
                        {
                            pol.Rotate();
                            Console.WriteLine($"Rotated? {pol.IfRotated}");
                        }
                        break;
                }
                Console.ReadKey();
            
            }



            //if (new1.IsExist() && new2.IsExist())
            //{
            //    if (new1.Space() == new2.Space())
            //    {
            //        Console.WriteLine("Triangles are equal in space");
            //        OutputTriangle(new1);
            //        OutputTriangle(new2);
            //    }
            //    else
            //    {
            //        Triangle[] triangles = new Triangle[2];
            //        triangles[0] = new1;
            //        triangles[1] = new2;
            //        Array.Sort(triangles);
            //        Console.WriteLine("smaller trianlgle:");
            //        OutputTriangle(triangles[0]);
            //        Console.WriteLine();
            //        Console.WriteLine("bigger trianlgle:");
            //        OutputTriangle(triangles[1]);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Can't compare. Maybe one of triangles does not exist?");
            //}
        }


        //create
        //static Triangle NewTriangle()
        //{
        //    Triangle triangle = new Triangle();

        //    Console.WriteLine("Enter side A:");
        //    double a = double.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter side B:");
        //    double b = double.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter side C:");
        //    double c = double.Parse(Console.ReadLine());
        //    triangle.Create(a, b, c);
        //    return triangle;
        //}


        //output compilation
        //static void OutputTriangle(Triangle tri)
        //{
        //    Console.WriteLine($"Sides: {tri.SideA():F2}, {tri.SideB():F2}, {tri.SideC():F2}.");
        //    if (tri.IsExist())
        //    {
        //        Console.WriteLine("Triangle exist!");
        //        Console.WriteLine($"Perimetr = {tri.Perimetr():F2}, Space = {tri.Space():F2}.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Triangle doesn't exist, sorry.");
        //    }

        //}
    }
}

