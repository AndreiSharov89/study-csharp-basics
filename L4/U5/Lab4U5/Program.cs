// Sharov Andrei group 124/11
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4U5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c=");
            double c = double.Parse(Console.ReadLine());
            double x1 = 0;
            double x2 = 0;
            int rootCount = Equation(a, b, c, ref x1, ref x2);
            
            switch (rootCount)
            {
                case -1:
                    Console.WriteLine($"Equation with a= {a:F2}, b= {b:F2}, c={c:F2} has no roots");
                    break;
                case 0:
                    Console.WriteLine($"Equation with a= {a:F2}, b= {b:F2}, c={c:F2} has one root x1=x2= {x1:F2}");
                    break;
                default:
                    Console.WriteLine($"Equation with a= {a:F2}, b= {b:F2}, c={c:F2} has roots x1= {x1:F2}, x2= {x2:F2}");
                    break;
            
            }
        }

        public static int Equation(in double a, in double b, in double c, ref double x1, ref double x2)
        {
            double d = Discriminant(a, b, c);
            int roots;

            if (d == 0)
            {
                roots = 0;
                //try
                //{
                    x1 = ((b * (-1)) + Math.Sqrt(d)) / (2 * a);
                //}
                //catch (FormatException)
                //{
                //    Console.WriteLine("Equation is not quadratic, a=0");
                //}

                x2 = x1;
            } 
            else if (d > 0)
            {
                roots = 1;
                //try
                //{
                    x1 = ((b * (-1)) + Math.Sqrt(d)) / (2 * a);
                    x2 = ((b * (-1)) - Math.Sqrt(d)) / (2 * a);
                //}
                //catch (FormatException)
                //{
                //    Console.WriteLine("Equation is not quadratic, a=0");
                //}

            }
            else
            {
                roots = -1;
            }
                        
            return roots;
        }

        private static double Discriminant(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            return d;
        }
        
    }
}

