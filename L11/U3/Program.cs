// Sharov Andrei group 124/11
using Lab2_U3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enum

{
    class Program
    {

        //public struct Dist
        //{
        //    public int foot;
        //    public int inch;
        //    //public int sumInches;
        //}

        static void Main(string[] args)
        {
            //Distance d1 = new Distance(2, 15);
            //Distance d2 = new Distance(3, 3);
            //Distance d1 = new Distance(5, 13);
            //Distance d2 = new Distance(3, 10);
            //Distance d1 = new Distance(2, 11);
            //Distance d2 = new Distance(4, 10);
            Distance d1 = new Distance(5, 3);
            Distance d2 = new Distance(2, 10);


            Distance d3 = new Distance();
            d3 = d1 + d2;
            Distance d4 = new Distance();
            d4 = d1 - d2;
            Console.WriteLine("D1 = " + d1);
            Console.WriteLine("D2 = " + d2);
            Console.WriteLine("Sum(D1+D2) = " + d3);
            Console.WriteLine("Dif(D1-D2) = " + d4);
            if (d1 < d2)
            {
                Console.WriteLine("D1<D2");
            }
            else 
            {
                if (d1 > d2) 
                {
                    Console.WriteLine("D1>D2");
                } 
                else 
                {
                    Console.WriteLine("D1=D2");
                }
            }










            //Dist firstDist;
            //Dist secondDist;
            //Dist sumDist;
            //Console.WriteLine("Enter first foots: ");
            //firstDist.foot = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter first inches: ");
            //firstDist.inch = int.Parse(Console.ReadLine());
            ////firstDist.sumInches = firstDist.foot * 12 + firstDist.inch;

            //Console.WriteLine("Enter second foots: ");
            //secondDist.foot = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second inches: ");
            //secondDist.inch = int.Parse(Console.ReadLine());
            ////secondDist.sumInches = secondDist.foot * 12 + secondDist.inch;

            ////sumDist.sumInches = firstDist.sumInches + secondDist.sumInches;
            //sumDist.foot = firstDist.foot + secondDist.foot + (int)((firstDist.inch + secondDist.inch)/12);
            //sumDist.inch = ((firstDist.inch + secondDist.inch) % 12);
            ////Console.WriteLine($"First in inches: {firstDist.sumInches}");
            ////Console.WriteLine($"Second in inches: {secondDist.sumInches}");
            //Console.WriteLine($"Summa: {sumDist.foot}'- {sumDist.inch}\"");
        }
    }
}