// Sharov Andrei group 124/11
using System;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Please enter the perimeter: ");
            string temp = Console.ReadLine();
            uint perimetr = uint.Parse(temp);
            double halfPerimetr = perimetr / 2;
            double side = perimetr / 3;
            double Space = Math.Sqrt(halfPerimetr * Math.Pow(halfPerimetr - side, 3));
            Console.WriteLine($"{"Triangle Side",15}  {"Triangle Space",15}");
            Console.WriteLine($"{string.Format($"{side:F2}"),15}  {string.Format($"{Space:F2}"),15}");
         }
        catch (FormatException e)
        {
            Console.WriteLine($"An format exception was thrown: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An exception was thrown: {e.Message}");
        }
    }
}
