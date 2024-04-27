using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class Test
    {
        static void Main()
        {
            string sMain;
            Console.WriteLine("Input a string, maybe I'll reverse it.");
            sMain = Console.ReadLine();

            Utils.Reverse(ref sMain);

            Console.WriteLine(sMain);
            Console.ReadKey();
        }
    }
}
