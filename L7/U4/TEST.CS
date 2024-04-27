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
            int a = -121;
            ulong b = 122;
            string c = "123";
            Console.WriteLine("int: {0}", Utils.IsItFormattable(a));
            Console.WriteLine("ulong: {0}", Utils.IsItFormattable(b));
            Console.WriteLine("string: {0}", Utils.IsItFormattable(c));
            Console.ReadKey();
        
        
        }
    }
}
