// Sharov Andrei group 124/11
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Triangle:IComparable
    {
        //fields
        private double sideA;
        private double sideB;
        private double sideC;


        //initialize fields
        //public void Create(double a, double b, double c)
        //{
        //    sideA = a;
        //    sideB = b;
        //    sideC = c;
        //}
        public Triangle()
        {
            sideA = 0;
            sideB = 0;
            sideC = 0;
        }

        public Triangle(double a)
        {
            sideA = a;
            sideB = a;
            sideC = a;
        }

        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }


        //call fields
        public double SideA()
        {
            return sideA;
        }
        public double SideB()
        {
            return sideB;
        }
        public double SideC()
        {
            return sideC;
        }


        //calculated properties
        public double Perimetr()
        {
            double p = sideA + sideB + sideC;
            return p;
        }
        public double Space()
        {
            double p = (sideA + sideB + sideC) / 2;
            double s = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            if (double.IsRealNumber(s))
            {
                return s;
            }
            else
            {
                return 0;
            }
        }
        public bool IsExist()
        {
            bool isExist = (sideA < sideB + sideC) && (sideB < sideA + sideC) && (sideC < sideB + sideA);
            return isExist;
        }


        int IComparable.CompareTo(object obj)
        {
            while (obj != null)
            {
                Triangle it = (Triangle)obj;
                if (this.Space() == it.Space())
                {
                    return 0;
                }
                else if (this.Space() > it.Space())
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            return -2;
        }
    }
}

