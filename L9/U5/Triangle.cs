// Sharov Andrei group 124/11
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Triangle:Shape,IRotate
    {
        //fields
        private double sideA;
        private double sideB;
        private double sideC;
                
        public Triangle()
        {
            sideA = 0;
            sideB = 0;
            sideC = 0;
            base.name = "Triangle";
        }

        public Triangle(double a)
        {
            sideA = a;
            sideB = a;
            sideC = a;
            base.name = "Triangle with equal sides";
        }

        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
            base.name = "Triangle with unequal sides";
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
        //interface relation
        public bool IfRotated { get; set; }
        public void Rotate()
        {
            this.IfRotated = true;
        }
    }
}


