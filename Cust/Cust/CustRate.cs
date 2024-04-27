// Sharov Andrei group 124/11

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class CustRate
    {
        static void Main()
        {
            string rate1, rate2;
            Console.WriteLine("Choose rate for first customer (fair, shortCall, longCall):");
            rate1 = Console.ReadLine();
            Customer Ivan = new Customer("Иван Петров", rate1, 500);
            Console.WriteLine("Choose rate for seconf customer (fair, shortCall, longCall):");
            rate2 = Console.ReadLine();
            Customer Elena = new Customer("Елена Иванова", rate2);
            Ivan.RecordCall('Г', 12, rate1);
            Elena.RecordCall('М', 25, rate2);

            Console.WriteLine(Ivan.ToString());
            Console.WriteLine(Elena.ToString());


        }
    }
}
//440 75 - fair fair
//445 75 - longCall longCall
//417.5 57.5 - shortCall shortCall