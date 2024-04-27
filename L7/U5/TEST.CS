namespace Utils
{
    using System;

    /// <summary>
    ///   This the test harness
    /// </summary>

    public class Test
    {
        public static void Main() 
        {
            int a = -123;
            string b = "123";
            Coordinate c = new Coordinate(21.0, 68.0);

            Utils.Display(a);
            Utils.Display(b);
            Utils.Display(c);
            Console.ReadKey();
        }
    }
}
