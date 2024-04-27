// Sharov Andrei group 124/11
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Square:Shape,IRotate
    {
        //fields
        private double side;

        public Square()
        {
            side = 0;
            base.name = "Point";
        }

        public Square(double a)
        {
            side = a;
            if (side < 0) 
            {
                side = 0;
            }
            base.name = "Square";
        }

        //call fields
        public double Side()
        {
            return side;
        }
        
        //calculated properties
        public double Perimetr()
        {
            double p = side*4;
            return p;
        }
        public double Space()
        {
            double s = Math.Pow(side, 2);
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

