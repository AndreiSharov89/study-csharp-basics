// Sharov Andrei group 124/11
namespace Lab4_U4
{
    public static class Operation
    {
        public static double TriSpace(double a, double b, double c)
        {
            double s = 0;
            double p = 0;
            try
            {
                if (IsExist(a, b, c))
                {
                    p = (a + b + c) / 2;
                    s =  Math.Sqrt(p*(p-a)*(p-b)*(p-c));
                    return s;
                }
                else
                {
                    throw new Exception("Triangle doesn't exist");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return 0;
            }

        }
        public static double TriSpace(double a)
        {
            double s = 0;
            double p = 0;
            p = a*1.5;
            s = Math.Sqrt(p * Math.Pow(p - a, 3));
            return s;

        }


        private static bool IsExist(double a, double b, double c)
        { 
        double p = (a + b + c) / 2;
        if (p<a || p<b || p<c)
                {
                return false;
                }
        else 
                {
                return true;
                }
        }
    }
}
