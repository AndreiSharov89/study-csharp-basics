// Sharov Andrei group 124/11
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Circle:Shape
    {
        //fields
        private double radius;



        public Circle()
        {
            radius = 0;
            base.name = "Point";
        }

        public Circle(double a)
        {
            radius = a;
            if (radius <= 0)
            {
                base.name = "Point";
            }
            else
            {
                base.name = "Circle";
            }
        }

        //call fields
        public double Radius()
        {
            return radius;
        }



        //calculated properties
        public double Perimetr()
        {
            double p = 0;
            if (this.radius > 0)
            {
                 p = 2 * Math.PI * radius;
            }
            return p;
        }
        public double Space()
        {
            double s = Math.PI*Math.Pow(radius, 2);
            if (this.radius>0)
            {
                return s;
            }
            else
            {
                return 0;
            }
        }
    }
}

