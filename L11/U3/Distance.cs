using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_U3
{
    internal class Distance
    {
        private int foot;
        private double inch;

        public Distance()
        { 
            this.foot = 0;
            this.inch = 0;
        } 
        public Distance(int foot, double inch)
        {

                this.foot = foot + (int)(inch / 12);
                this.inch = (inch % 12);

        }

        public static bool operator ==(Distance d1, Distance d2)
        { 
            if (d1.foot == d2.foot && d1.inch == d2.inch)
                return true;
            else return false;
        }
        public static bool operator !=(Distance d1, Distance d2)
        {
            if (d1.foot != d2.foot && d1.inch != d2.inch)
                return true;
            else return false;
        }
        public static bool operator < (Distance d1, Distance d2)
        {
            if (d1.foot*12+d1.inch < d2.foot*12+d2.inch)
                return true;
            else return false;
        }
        public static bool operator > (Distance d1, Distance d2)
        {
            if (d1.foot * 12 + d1.inch > d2.foot * 12 + d2.inch)
                return true;
            else return false;
        }
        public static Distance operator + (Distance d1, Distance d2)
        {
            int foot = d1.foot + d2.foot + (int)((d1.inch + d2.inch) / 12);
            double inch = (d1.inch + d2.inch)%12;
            Distance sum = new Distance(foot, inch);
            return sum;
        }
        public static Distance operator - (Distance d1, Distance d2)
        {
            double a = (d1.foot * 12 + d1.inch) - (d2.foot * 12 + d2.inch);
            //if (a < 0)
            //{
                int foot = (int)(a / 12);
                double inch = (a % 12);
                Distance dif = new Distance(foot, inch);
                return dif;
            //}
            //else
            //{
            //    int foot = (int)(a / 12);
            //    double inch = (a % 12);
            //    Distance dif = new Distance(foot, inch);
            //    return dif;
            //}


            
            //if (d1<d2)
            //{
            //    int foot = -1 * (int) ((d2.foot*12 - d1.foot*12 + d2.inch-d1.inch)/12);
            //    if (foot == 0)
            //    {
            //        double inch = -1 * ((d2.inch - d1.inch) % 12);
            //        Distance sum = new Distance(foot, inch);
            //        return sum;
            //    }
            //    else
            //    {
            //        if (d2.inch < d1.inch)
            //        {
            //            double inch = (12 + d1.inch - d2.inch) % 12;
            //            Distance sum = new Distance(foot+1, inch);
            //            return sum;
            //        }
            //        else
            //        {
            //            double inch = (d1.inch - d2.inch) % 12;
            //            Distance sum = new Distance(foot, inch);
            //            return sum;
            //        }
            //    }

            //}
            //else
            //{
            //    if (d1.inch < d2.inch)
            //    {
            //        int foot = d1.foot - d2.foot -1 +(int)((d2.inch - d1.inch) / 12);
            //        double inch = (12 + d1.inch - d2.inch) % 12;
            //        Distance sum = new Distance(foot, inch);
            //        return sum;
            //    }
            //    else
            //    {
            //        int foot = d1.foot - d2.foot + (int)((d1.inch - d2.inch) / 12);
            //        double inch = (d1.inch - d2.inch) % 12;
            //        Distance sum = new Distance(foot, inch);
            //        return sum;
            //    }
            //}

        }
        public override string ToString()
        {
            if (this.inch < 0)
            {
                int foot = (this.foot + (int)(this.inch / 12));
                double inch = (this.inch % 12);
            }
            else
            {
                int foot = (this.foot + (int)(this.inch / 12));
                double inch = (this.inch % 12);
            }
            
            Distance dif = new Distance(foot, inch);
            string str = $" {dif.foot}'  {dif.inch:F1}\"";
            return str;
        }
    }
}
