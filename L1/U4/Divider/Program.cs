// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Linq.Expressions;

try
{
    Console.WriteLine("Please enter the perimeter: ");
    string temp = Console.ReadLine();
    int perimetr = Int32.Parse(temp)
    double p = perimetr / 2;
    double a = perimetr / 3;
    double S = Math.sqrt(p * Math.Pow((p - a), 3));
    Console.WriteLine($"Square = {S}");
}

 /*   int i = Int32.Parse(temp);

    Console.WriteLine("Please enter the second integer: ");
    temp = Console.ReadLine();
    int j = Int32.Parse(temp);

    int k = i / j;
    Console.WriteLine($"{i} / {j} = {k}");
}*/
catch (FormatException e)
{
    Console.WriteLine($"An format exception was thrown: {e.Message}");
}
catch (Exception e) {
    Console.WriteLine($"An exception was thrown: {e.Message}");
}
