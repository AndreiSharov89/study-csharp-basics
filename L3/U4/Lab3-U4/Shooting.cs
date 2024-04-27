// Sharov Andrei group 124/11
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AimShooting
{
    class AimShooting
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int resultShooting = 0;
            int i = 0;
            string[] Table = new string[10];
            do
            {
                Console.WriteLine("Your shot, x=");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Your shot, y=");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine($"You aimed at {x:F2} and {y:F2}");
                //trouble gives +/- 0.5 to result
                x = (x - rand.NextDouble() + 0.5);
                y = (y - rand.NextDouble() + 0.5);
                Console.WriteLine($"But you shoot at {x:F2} and {y:F2}");
                //blind shooting moves center +/- 1
                //double centerX = 0;
                //double centerY = 0;
                double centerX = 0 + (2 * (rand.NextDouble() - 0.5));
                double centerY = 0 + (2 * (rand.NextDouble() - 0.5));
                //Console.WriteLine($"And you know what? Center is at {centerX:F2} and {centerY:F2}");
                double radius = Math.Sqrt(Math.Pow((x - centerX), 2) + Math.Pow((y - centerY), 2));
                //took second option of target
                int resultShot = 0;
                if (radius <= 1)
                {
                    resultShot += 10;
                }
                if (radius > 1 && radius <= 2)
                {
                    resultShot += 5;
                }
                if (radius > 2 && radius <= 3)
                {
                    resultShot += 1;
                }
                Console.WriteLine($"Result of this shot is: {resultShot}");

                Console.WriteLine("One more shoot? y/n:");
                resultShooting += resultShot;
                Table[i] = $"{string.Format($"{x:F2}, {y:F2}"), 12} | {string.Format($"{centerX:F2}, {centerY:F2}"),12} | {string.Format($"{radius:F2}"),6} | {string.Format($"{resultShot:F2}"),6} | {string.Format($"{resultShooting:F2}"),6}";
                i++;
            }
            while (Console.ReadLine() == "y");
            Console.WriteLine($"After all you got: {resultShooting}");
            Console.WriteLine($"More specific results table:");
            Console.WriteLine($"{"Shot", 12} | {"Center", 12} | {"Dist", 6} | {"Result", 6} | {"Sum", 6}");
            
            foreach (string resultString in Table) 
            {
                Console.WriteLine(resultString);
            }

        }

    }
}