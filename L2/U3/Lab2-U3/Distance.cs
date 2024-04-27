// Sharov Andrei group 124/11
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enum

{
    class Distance
    {

        public struct Dist
        {
            public int foot;
            public int inch;
            //public int sumInches;
        }

        static void Main(string[] args)
        {
            Dist firstDist;
            Dist secondDist;
            Dist sumDist;
            Console.WriteLine("Enter first foots: ");
            firstDist.foot = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first inches: ");
            firstDist.inch = int.Parse(Console.ReadLine());
            //firstDist.sumInches = firstDist.foot * 12 + firstDist.inch;

            Console.WriteLine("Enter second foots: ");
            secondDist.foot = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second inches: ");
            secondDist.inch = int.Parse(Console.ReadLine());
            //secondDist.sumInches = secondDist.foot * 12 + secondDist.inch;

            //sumDist.sumInches = firstDist.sumInches + secondDist.sumInches;
            sumDist.foot = firstDist.foot + secondDist.foot + (int)((firstDist.inch + secondDist.inch)/12);
            sumDist.inch = ((firstDist.inch + secondDist.inch) % 12);
            //Console.WriteLine($"First in inches: {firstDist.sumInches}");
            //Console.WriteLine($"Second in inches: {secondDist.sumInches}");
            Console.WriteLine($"Summa: {sumDist.foot}'- {sumDist.inch}\"");
        }
    }
}