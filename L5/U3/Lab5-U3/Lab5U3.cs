// Sharov Andrei group 124/11
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
namespace Lab5U3 
{
    public class Lab5U3
    {
        public static void Main()
        {
            Console.WriteLine($"Enter array length:");
            int arLength = int.Parse(Console.ReadLine());
            double[] input = new double[arLength];
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"Enter array element {i}:");
                input[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum of elements = {Sum(input)}");
            Console.WriteLine($"Mean of elements = {Med(input)}");
            (double positive, double negative) separatedSum1 = SeparatedSum(input);
            Console.WriteLine($"Sum of positives = {separatedSum1.positive}");
            Console.WriteLine($"Sum of negatives = {separatedSum1.negative}");
            (double even, double odd) separatedSum2 = EvOddSum(input);
            Console.WriteLine($"Sum on even positions = {separatedSum2.even}");
            Console.WriteLine($"Sum of negatives = {separatedSum2.odd}");
            (int maxIndex, int minIndex) arrIndexes = ArrMinMax(input);
            Console.WriteLine($"Minimum element index = {arrIndexes.minIndex} (first occurrence)");
            Console.WriteLine($"Maximum element index = {arrIndexes.maxIndex} (first occurrence)");
            Console.WriteLine($"Multiplication of elemens between min and max elements= {MulMinMax(input, arrIndexes.minIndex, arrIndexes.maxIndex)}");
        }
        private static double Sum(in double[] input)
        {
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum;
        }
        private static double Med(in double[] input)
        {
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return (sum / input.Length);
        }
        private static (double, double) SeparatedSum(in double[] input)
        {
            (double positive, double negative) separatedSum = (0, 0);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    separatedSum.positive += input[i];
                }
                else
                {
                    separatedSum.negative += input[i];
                }
            }
            return separatedSum;
        }
        private static (double, double) EvOddSum(in double[] input)
        {
            (double even, double odd) separatedSum = (0, 0);
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    separatedSum.even += input[i];
                }
                else
                {
                    separatedSum.odd += input[i];
                }
            }
            return separatedSum;
        }
        private static (int, int) ArrMinMax(in double[] input)
        {
            (double min, double max) ArrMinMax = (input[0], input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] < ArrMinMax.min)
                {
                ArrMinMax.min = input[i];
                }

                if (input[i] > ArrMinMax.max)
                {
                ArrMinMax.max = input[i];
                }
            }
            int indexMin = Array.IndexOf(input, ArrMinMax.min);
            int indexMax = Array.IndexOf(input, ArrMinMax.max);
            return (indexMax, indexMin);
        }
        private static double MulMinMax(in double[] input, in int a, in int b)
        {
            double mul = 1;
            if (a > b)
            {
                for (int i = b; i <= a; i++)
                    mul *= input[i];
            }   else
            {
                for (int i = a; i <= b; i++)
                    mul *= input[i];
            }
            return mul;
        }

    }
}