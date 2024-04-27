// Sharov Andrei group 124/11
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkNamespace
{
    public class AkProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c=");
            double c = double.Parse(Console.ReadLine());

            (int roots, double x1, double x2) solution = Equation(a, b, c);

            switch (solution.roots)
            {
                case -1:
                    Console.WriteLine($"Equation with a= {a:F2}, b= {b:F2}, c={c:F2} has no roots");
                    break;
                case 0:
                    Console.WriteLine($"Equation with a= {a:F2}, b= {b:F2}, c={c:F2} has one root x1=x2= {solution.x1:F2}");
                    break;
                case 2:
                    Console.WriteLine("Equation is not quadraic");
                    break;
                default:
                    Console.WriteLine($"Equation with a= {a:F2}, b= {b:F2}, c={c:F2} has roots x1= {solution.x1:F2}, x2= {solution.x2:F2}");
                    break;

            }
        }



        public static (int, double, double) Equation(in double a, in double b, in double c)
        {

            double d = Discriminant(a, b, c);
            double x1 = ((b * (-1)) + Math.Sqrt(d)) / (2 * a);
            double x2 = ((b * (-1)) - Math.Sqrt(d)) / (2 * a);
            int roots = 2;

            if (d > 0 && double.IsFinite(x1) && double.IsFinite(x2))
            {
                roots = 1;
            }
            else if (d == 0 && double.IsFinite(x1))
            {
                x2 = x1;
                roots = 0;
            }
            else if (d < 0)
            {
                roots = -1;
            }

            (int, double, double) Solution = (roots, x1, x2);
            return Solution;

        }

        private static double Discriminant(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            return d;
        }

    }
}

