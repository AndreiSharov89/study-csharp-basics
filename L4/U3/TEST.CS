// Sharov Andrei group 124/11
namespace Utils
{
    using System;

    /// <summary>
    ///   This is the test harness
    /// </summary>

    public class Test
    {
        public static void Main()
        {
            int x;
            int y;
            bool ok;
            int f;
            
            Console.WriteLine("enter x:");
            x = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter y");
            //y = int.Parse(Console.ReadLine());


            //int greather = Utils.Greater(x, y);
            //Console.WriteLine($"Greather = {greather}");
            //Console.ReadLine();
            //Console.WriteLine("Before swap: " + x + "," + y);
            //Utils.Swap(ref x, ref y);
            //Console.WriteLine("After swap: " + x + "," + y);
            //Console.ReadLine();
            ok = Utils.Factorial(x, out f);
            if (ok)
            {
                Console.WriteLine("Factorial(" + x + ") = " + f);
            }
            else
            {
                Console.WriteLine("Cannot compute this factorial");
            }
            Console.ReadLine();

            // Put your test code in here			
        }
        
    }
}
