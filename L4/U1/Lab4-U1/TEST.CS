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
            
            Console.WriteLine("enter x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter y");
            y = int.Parse(Console.ReadLine());

            
            int greather = Utils.Greater(x, y);
            Console.WriteLine($"Greather = {greather}");
            Console.ReadLine();
            // Put your test code in here			
        }
    }
}
