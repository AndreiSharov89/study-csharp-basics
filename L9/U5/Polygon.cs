// Sharov Andrei group 124/11
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Polygon : Shape, IRotate
    {
        //fields
        private double side;
        private double sides;

        public Polygon()
        {
            side = 1;
            sides = 5;
            base.name = "Pentagon";
        }

        public Polygon(double a)
        {
            side = a;
            if (side < 0)
            {
                side = 0;
            }
            base.name = "Point";
        }
        public Polygon(double a, double b)
        {
            side = a;
            if (side < 0)
            {
                side = 0;
            }
            sides = b;
            base.name = "Polygon";
        }
        //call fields
        public double Side()
        {
            return side;
        }
        public double Sides()
        {
            return sides;
        }

        //calculated properties
        public double Perimetr()
        {
            double p = side * sides;
            return p;
        }
        public double Space()
        {
            double s = (sides/4)*(Math.Pow(side, 2)*(1/Math.Tan(Math.PI/(Math.Pow(sides, 2)))));
            return s;
        }

        //interface relation
        public bool IfRotated { get; set; }
        public void Rotate()
        {
            this.IfRotated = true;
        }
    }
}

