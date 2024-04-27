//Sharov Andrei group 124/11
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AlgAsMethod
{
    class A
    {

        static double SqareRoot(double aim)
        {
            double r = 1;
            double oldr;
            do
            {
                oldr = r;
                r = (r + aim / r) / 2;
            }
            while (oldr != r);
            return r;
        }
        static void Main(string[] args)
        {
            double target;
            double root;
            Console.WriteLine("Enter num to get square root:");
            target = double.Parse(Console.ReadLine());

            root = SqareRoot(target);

            Console.WriteLine($"Your square root is: {root:F2}");
            target = root * root;
            Console.WriteLine($"Your first number was {target:F2}");

        }
    }

}